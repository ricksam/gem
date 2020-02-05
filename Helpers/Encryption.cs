namespace GEM.Helpers
{
    public class Encryption{
        public static string md5(string input)
        {
            if (string.IsNullOrEmpty(input)) {
                return "";
            }
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            { sb.Append(hash[i].ToString("x2")); }
            return sb.ToString();
        }
    }
}