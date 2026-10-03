namespace SmartFleet.Utility
{
    public class ProductValidateHelper
    {
        private static List<KeyClass> KeyClassList { get; set; } = new();

        public static ProductKeyValidateResultModel ValidateProductKeyWithMessage(string productLicenseCode, string companyName)
        {
            var result = new ProductKeyValidateResultModel();

            if (string.IsNullOrWhiteSpace(productLicenseCode))
            {
                result.ValidateStatus = false;
                result.ValidateMessge = "Update License";
                return result;
            }

            if (productLicenseCode.Length < 8)
            {
                result.ValidateStatus = false;
                result.ValidateMessge = "Invalid product license. Please contact the support team.";
                return result;
            }

            try
            {
                FillKeyClassList();

                string productKey = productLicenseCode[^8..];
                string dateOfExpiration = string.Empty;

                foreach (char character in productKey)
                {
                    var key = KeyClassList.FirstOrDefault(x =>
                        x.Char1 == character || x.Char2 == character || x.Char3 == character ||
                        x.Char4 == character || x.Char5 == character || x.Char6 == character);

                    if (key == null)
                    {
                        result.ValidateStatus = false;
                        result.ValidateMessge = "Invalid product license. Please contact the support team.";
                        return result;
                    }

                    dateOfExpiration += key.Number.ToString();
                }

                if (dateOfExpiration.Length != 8 ||
                    !int.TryParse(dateOfExpiration[..2], out var day) ||
                    !int.TryParse(dateOfExpiration.Substring(2, 2), out var month) ||
                    !int.TryParse(dateOfExpiration.Substring(4, 4), out var year))
                {
                    result.ValidateStatus = false;
                    result.ValidateMessge = "Invalid product license. Please contact the support team.";
                    return result;
                }

                if (!DateTime.TryParse($"{year:D4}-{month:D2}-{day:D2}", out var expiration))
                {
                    result.ValidateStatus = false;
                    result.ValidateMessge = "Invalid product license. Please contact the support team.";
                    return result;
                }

                result.validTillDate = expiration.ToString("O");

                if (DateTime.Now > expiration)
                {
                    result.ValidateStatus = false;
                    result.BalanceRenewalDays = 0;
                    result.ValidateMessge = "Update License";
                    return result;
                }

                result.ValidateStatus = true;
                result.BalanceRenewalDays = Math.Max((expiration - DateTime.Now).Days, 0);
                result.ValidateMessge = result.BalanceRenewalDays < 10
                    ? $"Your licence will expire in {result.BalanceRenewalDays} days"
                    : $"The product is licensed to {companyName}";

                return result;
            }
            catch
            {
                result.ValidateStatus = false;
                result.ValidateMessge = "Invalid product license. Please contact the support team.";
                return result;
            }
        }

        private static void FillKeyClassList()
        {
            KeyClassList = new List<KeyClass>();
            AddKey(0, 'F', 'P', 'Z', 't', 'd', 'n');
            AddKey(1, 'G', 'Q', 'A', 'u', 'e', 'o');
            AddKey(2, 'H', 'R', 'B', 'v', 'f', 'p');
            AddKey(3, 'I', 'S', 'C', 'w', 'g', 'q');
            AddKey(4, 'J', 'T', '8', 'x', 'h', 'r');
            AddKey(5, 'K', 'U', '9', 'y', 'i', '3');
            AddKey(6, 'L', 'V', '0', 'z', 'j', '4');
            AddKey(7, 'M', 'W', '1', 'a', 'k', '5');
            AddKey(8, 'D', 'N', 'X', '2', 'b', 'l');
            AddKey(9, 'E', 'O', 'Y', 's', 'c', 'm');
        }

        private static void AddKey(int number, char char1, char char2, char char3, char char4, char char5, char char6)
        {
            KeyClassList.Add(new KeyClass
            {
                Number = number, Char1 = char1, Char2 = char2, Char3 = char3,
                Char4 = char4, Char5 = char5, Char6 = char6
            });
        }
    }
}