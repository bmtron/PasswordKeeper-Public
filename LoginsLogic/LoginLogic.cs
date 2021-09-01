using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginsDB.models;
using System.Configuration;
using DTOs;




namespace LoginsLogic
{
    public class LoginLogic
    {
        public InfoEntities db = new InfoEntities();

        private static readonly string phrase = Secrets.passKey;


        public bool authenticateMasterLogin(string userName, string password)
        {
            var userNameCount = db.master_login.Where(m => m.m_username == userName).Count();

            if (userNameCount == 0)
            {
                return false;
            }

            var existingLogin = db.master_login.Where(m => m.m_username == userName).First();

            if (password == Crypto128Update.Decrypt(existingLogin.m_password, phrase))
            {
               // updateAllLoginsToUse128BitEncryption();
                return true;
            }

            return false;
        }

        public List<LoginDdlDTO> getAllAccounts()
        {

            var loginsDtoList = new List<LoginDdlDTO>();
            db.logins.OrderBy(l => l.account).ToList().ForEach(log =>
                loginsDtoList.Add(
                    new LoginDdlDTO { LoginID = log.login_id.ToString(), Account = log.account.ToString() }
                    )
            );

            loginsDtoList.Insert(0, new LoginDdlDTO { LoginID = "-1", Account = "Please select an account." });


            return loginsDtoList;
        }

        public LoginDTO getLoginInfo(string selectedItem)
        {
            var loginDto = db.logins.Where(log => log.login_id.ToString() == selectedItem)
                .Select(l => 
                new LoginDTO { LoginID = l.login_id.ToString(), Account = l.account, Password = l.password, PricePerMonth = l.price_per_month, Username = l.username, RenewalDate = l.renewal_date, Website = l.website })
                .First();
            loginDto.PlainTextPassword = Crypto128Update.Decrypt(loginDto.Password, phrase);
            return loginDto;
        }

        public void addNewLogin(LoginDTO loginDto)
        {
            login newLogin = new login();

            newLogin.password = Crypto128Update.Encrypt(loginDto.Password, phrase);
            newLogin.username = loginDto.Username;
            newLogin.account = loginDto.Account;
            newLogin.price_per_month = loginDto.PricePerMonth;
            newLogin.renewal_date = loginDto.RenewalDate;
            newLogin.website = loginDto.Website;

            db.logins.Add(newLogin);
            db.SaveChanges();
        }

        public void updateAllLoginsToUse128BitEncryption()
        {
            List<login> loginList = db.logins.ToList();
            List<master_login> masterLoginList = db.master_login.ToList();

            foreach (var login in loginList)
            {
                string decryptedLogin = Crypto.Decrypt(login.password, phrase);
                string newPassword = Crypto128Update.Encrypt(decryptedLogin, phrase);
                login.password = newPassword;
                db.SaveChanges();
            }
            foreach(var login in masterLoginList)
            {
                string decryptedLogin = Crypto.Decrypt(login.m_password, phrase);
                string newPassword = Crypto128Update.Encrypt(decryptedLogin, phrase);
                login.m_password = newPassword;
                db.SaveChanges();
            }
        }

        public void updatePassword(LoginDTO loginDto, string newPass)
        {
            var login = db.logins.Where(l => l.login_id.ToString() == loginDto.LoginID).First();
            login.password = Crypto128Update.Encrypt(newPass, phrase);
            db.SaveChanges();
        }
    }
}
