using System;
using System.Collections.Generic;
 
using System.Diagnostics;
using System.Text.RegularExpressions;
using Xamarin.Forms;
using System.Text;
namespace S2KLogin
{
	public partial class PasswordFind : ContentPage
	{
		String userID, userEmail;
		public PasswordFind ()
		{
			

			InitializeComponent ();
			 

		}
		  
		  public static bool EmailIsValid(string email)
		{
			return Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
		}

		public void FindPW(object sender, EventArgs args)
		{
			userID = IDEntry.Text;
			userEmail = EmailEntry.Text;

			if (userID.Length < 4 || userEmail.Length <= 0)
			{
				DisplayAlert("ID Error", "The ID or Password you entered is invalid", "OK");
				return;
			}
			if (!EmailIsValid(userEmail))
			{
				DisplayAlert("Email Error", "The email you entered is invalid", "OK");
				return;
			}
			byte[] emailBytes = Encoding.UTF8.GetBytes(userEmail);
			String hexedEmail = bytesToHex(emailBytes);
			Secure2Key.pc_requestTempPassword(userID, StaticValues.reqNumber, hexedEmail);
		}









		protected static char[] hexArray = "0123456789ABCDEF".ToCharArray();
		public static String bytesToHex(byte[] bytes)
		{
			char[] hexChars = new char[bytes.Length * 2];
			for (int j = 0; j < bytes.Length; j++)
			{
				int v = bytes[j] & 0xFF;
				hexChars[j * 2] = hexArray[v >> 4];
				hexChars[j * 2 + 1] = hexArray[v & 0x0F];
			}
			return new String(hexChars);
		}

		  
		 
	}
}

