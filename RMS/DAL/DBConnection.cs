using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RMS.DAL
{
    public class DBConnection
    {
        public static SqlConnection DBConnect()

        {
            var conn = new SqlConnection();
            // conn.ConnectionString = "SERVER=localhost:8000;DATABASE=econtactdb;UID=root;Password=";
            conn.ConnectionString = "Data Source=.;Initial Catalog=RMS;Integrated Security=True";
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();

            }
            return conn;
        }

        public static DataTable gettablebyquery(string SqlQuery)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = DBConnect();
                command.CommandText = SqlQuery;
                command.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static void ExecuteNonQuery(string SqlQuery)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = DBConnect();
                command.CommandText = SqlQuery;
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }

        }





        public static string Encrypt(string toEncrypt, bool useHashing)
        {
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

            AppSettingsReader settingsReader =
                                                new AppSettingsReader();
            // Get the key from config file

            string key = (string)settingsReader.GetValue("SecurityKey",
                                                             typeof(String));
            //System.Windows.Forms.MessageBox.Show(key);
            //If hashing use get hashcode regards to your key
            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                //Always release the resources and flush data
                // of the Cryptographic service provide. Best Practice

                hashmd5.Clear();
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            //set the secret key for the tripleDES algorithm
            tdes.Key = keyArray;
            //mode of operation. there are other 4 modes.
            //We choose ECB(Electronic code Book)
            tdes.Mode = CipherMode.ECB;
            //padding mode(if any extra byte added)

            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            //transform the specified region of bytes array to resultArray
            byte[] resultArray =
              cTransform.TransformFinalBlock(toEncryptArray, 0,
              toEncryptArray.Length);
            //Release resources held by TripleDes Encryptor
            tdes.Clear();
            //Return the encrypted data into unreadable string format
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }
    }
}
