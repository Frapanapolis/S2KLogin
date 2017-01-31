using System;
using System.Collections.Generic;
using S2KLogin.Helpers;
using Xamarin.Forms;
 
namespace S2KLogin
{
	public partial class PasswordMenu : ContentPage
	{
		public PasswordMenu ()
		{
			InitializeComponent ();
		}

		public void PWON(object sender, EventArgs args)
		{
			Secure2Key.writeIsPWOn(1);
			String saveData = Secure2Key.getEncData();
			Settings.Data = saveData;
 
			 
		}

		public void PWOFF(object sender, EventArgs args)
		{
			Secure2Key.writeIsPWOn(-1);
			String saveData = Secure2Key.getEncData();
			Settings.Data = saveData;



		}
		  
	}
}

