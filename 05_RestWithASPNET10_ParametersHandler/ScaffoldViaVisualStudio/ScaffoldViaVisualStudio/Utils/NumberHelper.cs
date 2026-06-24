namespace ScaffoldViaVisualStudio.Utils
{
    public class NumberHelper
    {
        public static decimal ConvertToDecimal(string number)
        {
            decimal decimalValue;
            if (decimal.TryParse(
                number,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out decimalValue))
            {
                return decimalValue;
            }

            return 0;
        }

        public static bool IsNumeric(string number)
        {
            decimal decimalValue;
            bool IsNumber = decimal.TryParse(
                number,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out decimalValue);
            return IsNumber;
        }
    }
}
