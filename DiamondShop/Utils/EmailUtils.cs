using System.Text.RegularExpressions;

namespace DiamondShop.Utils
{
	public class EmailUtils
	{
		public static bool IsValidEmail(string email)
		{
			// Regular expression pattern for validating email addresses
			string pattern = @"^[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-zA-Z]{2,}$";

			Regex regex = new Regex(pattern);

			// Match the email address against the pattern
			return regex.IsMatch(email);
		}
	}
}
