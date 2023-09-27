namespace IsEven.Implementation.Extensions
{
    internal static class IsEvenExtensions
    {
        public static string LastCharacter(this string text)
        {
            if (string.IsNullOrWhiteSpace(text) || text.Length == 0)
            {
                return string.Empty;
            }

            int decimalPointIndex = text.IndexOf('.');

            string integerPart = decimalPointIndex >= 0 ? text[..decimalPointIndex] : text;

            return integerPart[^1].ToString();
        }
    }
}
