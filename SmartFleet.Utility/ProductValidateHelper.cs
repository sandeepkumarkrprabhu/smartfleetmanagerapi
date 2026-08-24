
namespace SmartFleet.Utility
{
    public class ProductValidateHelper
    {
        static List<KeyClass> KeyClassList { get; set; }
        public static ProductKeyValidateResultModel ValidateProductKeyWithMessage(string productLicenseCode, string companyName)
        {
            var result = new ProductKeyValidateResultModel();
            bool flag = true;

            if (!string.IsNullOrWhiteSpace(productLicenseCode))
            {
                FillKeyClassList();
                string productKey = productLicenseCode.Substring(productLicenseCode.Length - 8, 8);
                string DateOfExpiration = string.Empty;
                foreach (char s in productKey)
                {
                    foreach (KeyClass key in KeyClassList)
                    {
                        if (key.Char1 == s || key.Char2 == s || key.Char3 == s || key.Char4 == s || key.Char5 == s || key.Char6 == s)
                        {
                            DateOfExpiration = DateOfExpiration + key.Number.ToString();
                        }
                    }
                }
                string day = DateOfExpiration.Substring(0, 2);
                string month = DateOfExpiration.Substring(2, 2);
                string year = DateOfExpiration.Substring(4, 4);
                DateTime expiration = new DateTime(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)); //Convert.ToDateTime(day + "/" + month + "/" + year);
                if (DateTime.Now > expiration)
                {
                    result.ValidateMessge = "Update License";
                    flag = false;
                }
                else
                {
                    flag = true;
                    result.validTillDate = expiration.ToString();
                    result.BalanceRenewalDays = (expiration - DateTime.Now).Days;
                    result.ValidateMessge = (result.BalanceRenewalDays < 10 ? "Your licence will expire in " + result.BalanceRenewalDays.ToString() + " days" : $"The product is licensed to {companyName}");
                }
            }
            else
            {
                result.ValidateMessge = "Update License";
                flag = false;
            }
            result.ValidateStatus = flag;
            return result;
        }


        private static void FillKeyClassList()
        {
            KeyClassList = new List<KeyClass>();
            KeyClass keyClass = new KeyClass();

            keyClass.Number = 0;
            keyClass.Char1 = 'F';
            keyClass.Char2 = 'P';
            keyClass.Char3 = 'Z';
            keyClass.Char4 = 't';
            keyClass.Char5 = 'd';
            keyClass.Char6 = 'n';

            KeyClassList.Add(keyClass);


            keyClass = new KeyClass();

            keyClass.Number = 1;
            keyClass.Char1 = 'G';
            keyClass.Char2 = 'Q';
            keyClass.Char3 = 'A';
            keyClass.Char4 = 'u';
            keyClass.Char5 = 'e';
            keyClass.Char6 = 'o';
            KeyClassList.Add(keyClass);

            keyClass = new KeyClass();

            keyClass.Number = 2;
            keyClass.Char1 = 'H';
            keyClass.Char2 = 'R';
            keyClass.Char3 = 'B';
            keyClass.Char4 = 'v';
            keyClass.Char5 = 'f';
            keyClass.Char6 = 'p';
            KeyClassList.Add(keyClass);

            keyClass = new KeyClass();

            keyClass.Number = 3;
            keyClass.Char1 = 'I';
            keyClass.Char2 = 'S';
            keyClass.Char3 = 'C';
            keyClass.Char4 = 'w';
            keyClass.Char5 = 'g';
            keyClass.Char6 = 'q';
            KeyClassList.Add(keyClass);

            keyClass = new KeyClass();

            keyClass.Number = 4;
            keyClass.Char1 = 'J';
            keyClass.Char2 = 'T';
            keyClass.Char3 = '8';
            keyClass.Char4 = 'x';
            keyClass.Char5 = 'h';
            keyClass.Char6 = 'r';


            KeyClassList.Add(keyClass);

            keyClass = new KeyClass();

            keyClass.Number = 5;
            keyClass.Char1 = 'K';
            keyClass.Char2 = 'U';
            keyClass.Char3 = '9';
            keyClass.Char4 = 'y';
            keyClass.Char5 = 'i';
            keyClass.Char6 = '3';
            KeyClassList.Add(keyClass);

            keyClass = new KeyClass();

            keyClass.Number = 6;
            keyClass.Char1 = 'L';
            keyClass.Char2 = 'V';
            keyClass.Char3 = '0';
            keyClass.Char4 = 'z';
            keyClass.Char5 = 'j';
            keyClass.Char6 = '4';
            KeyClassList.Add(keyClass);

            keyClass = new KeyClass();

            keyClass.Number = 7;
            keyClass.Char1 = 'M';
            keyClass.Char2 = 'W';
            keyClass.Char3 = '1';
            keyClass.Char4 = 'a';
            keyClass.Char5 = 'k';
            keyClass.Char6 = '5';
            KeyClassList.Add(keyClass);

            keyClass = new KeyClass();

            keyClass.Number = 8;
            keyClass.Char1 = 'D';
            keyClass.Char2 = 'N';
            keyClass.Char3 = 'X';
            keyClass.Char4 = '2';
            keyClass.Char5 = 'b';
            keyClass.Char6 = 'l';
            KeyClassList.Add(keyClass);

            keyClass = new KeyClass();

            keyClass.Number = 9;
            keyClass.Char1 = 'E';
            keyClass.Char2 = 'O';
            keyClass.Char3 = 'Y';
            keyClass.Char4 = 's';
            keyClass.Char5 = 'c';
            keyClass.Char6 = 'm';
            KeyClassList.Add(keyClass);

        }
    }
}
