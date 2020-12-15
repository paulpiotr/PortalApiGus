using System;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

namespace PortalApiGusApiRegonData.Helper
{
    public static class ObjectHelper
    {
        /// <summary>
        /// log4net
        /// </summary>
        private static readonly log4net.ILog Log4net = Log4netLogger.Log4netLogger.GetLog4netInstance(MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Konwertuj objekt na string
        /// </summary>
        /// <param name="o">o As object</param>
        /// <returns>string ciąg lub null</returns>
        public static string ObjectToString(object o)
        {
            try
            {
                if (null != o)
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    foreach (PropertyInfo propertyInfo in o.GetType().GetProperties())
                    {
                        stringBuilder.Append(propertyInfo.GetValue(o, null) ?? string.Empty);
                    }
                    return stringBuilder.ToString();
                }
                return null;
            }
            catch (Exception e)
            {
                Log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static string ObjectToSHA512(object o)
        {
            try
            {
                string objectToString = ObjectToString(o);
                if (null != objectToString && !string.IsNullOrWhiteSpace(objectToString))
                {
                    using (SHA512 sHA512 = new SHA512Managed())
                    {
                        return Convert.ToBase64String(sHA512.ComputeHash(Encoding.UTF8.GetBytes(objectToString)));
                    }
                    //byte[] getBytes = Encoding.UTF8.GetBytes(objectToString);
                    //using (System.Security.Cryptography.SHA512 sha512 = System.Security.Cryptography.SHA512.Create())
                    //{
                    //    byte[] computeHash = sha512.ComputeHash(getBytes);
                    //    StringBuilder stringBuilder = new StringBuilder(128);
                    //    foreach (var b in computeHash)
                    //    {
                    //        stringBuilder.Append(b.ToString("X2"));
                    //    }
                    //    return stringBuilder.ToString();
                    //}
                }
                return null;
            }
            catch (Exception e)
            {
                Log4net.Error(string.Format("{0}, {1}", e.Message, e.StackTrace), e);
                return null;
            }
        }
    }
}
