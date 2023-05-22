using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Policy;

namespace SQLServer_LiteDB_WinForms_LearningProject
{
    public class User
    {

        public string username { get; set; }
        public string passwordHash { get; set; }
        public string passwordSalt { get; set; }

    }

    public static class UserAuthentication
    {
        public static void insertUser(string _username, string _password)
        {
            using (var connection = new LiteDatabase(DatabaseConnectionHelper.connectionString("LiteDB_Login")))
            {
                var col = connection.GetCollection<User>();

                var salt = getSalt(64);
                var hash = getHash(_password, 64, salt);

                var user = new User { username = _username, passwordHash = hash, passwordSalt = Convert.ToHexString(salt) };

                col.Insert(user);
            }
        }

        public static bool checkUser(string _username, string _password)
        {
            using (var connection = new LiteDatabase(DatabaseConnectionHelper.connectionString("LiteDB_Login")))
            {
                var col = connection.GetCollection<User>();

                var result = col.Find(x => x.username.Equals(_username));

                foreach (var item in result)
                {
                    if(VerifyPassword(_password, item.passwordHash, Convert.FromHexString(item.passwordSalt)))
                    {
                        return true;
                    }
                }

                return false;
            }
        }

        private static byte[] getSalt(int length)
        {
            return RandomNumberGenerator.GetBytes(length);
        }

        private static string getHash(string _password, int length, byte[] salt)
        {
            var hash = Rfc2898DeriveBytes.Pbkdf2(
                Encoding.UTF8.GetBytes(_password),
                salt,
                400000,
                HashAlgorithmName.SHA512,
                length);

            return Convert.ToHexString(hash);
        }

        private static bool VerifyPassword(string password, string hash, byte[] salt)
        {
            var hashToCompare = Rfc2898DeriveBytes.Pbkdf2(password, salt, 400000, HashAlgorithmName.SHA512, 64);
            return CryptographicOperations.FixedTimeEquals(hashToCompare, Convert.FromHexString(hash));
        }
    }
}
