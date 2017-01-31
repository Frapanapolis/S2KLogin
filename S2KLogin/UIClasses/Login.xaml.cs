using System;
using System.Collections.Generic;
using S2KLogin.Helpers;
using Xamarin.Forms;
using Plugin.Connectivity;


namespace S2KLogin
{
	public partial class Login : ContentPage
	{

		private static String idValue;
		private static String pwValue;
		private static String loginResult;


		public Login()
		{
			InitializeComponent();
		}
		public async void OnLogin(object sender, EventArgs args)
		{


			idValue = IDEntry.Text;
			pwValue = PWEntry.Text;
			if (isNetworkConnected())
			{
				if (!idValue.Equals("") && !pwValue.Equals(""))
				{
					await Navigation.PushModalAsync(new Password(), false);

				}
				else
				{
					await DisplayAlert("Input Error", "Enter ID & PW", "OK");
				}
			}
			else
			{
				await DisplayAlert("Network Error", "Please check your Network Connection.", "OK");
			}
		}

		private void registerOkay()
		{
			/////////////////////////////////////
			Secure2Key.writePassword("0000");
			String saveData = Secure2Key.getEncData();
			Settings.Data = saveData;
			String state = "ON";

			Settings.Vibration = state;
			Settings.Sound = state;


			/////////////////////////////////////

			DisplayAlert("Password", "Default Paswword id 0000", "OK");


		}
 		private Boolean isNetworkConnected()
		{
			Boolean connected = false;

			//		ConnectivityManager connManager = (ConnectivityManager)getSystemService(Context.CONNECTIVITY_SERVICE);
			//		NetworkInfo networkInfo = connManager.getActiveNetworkInfo();


 			 

			return connected;
		}



		private  void TaskLogin() {

			String resultLoginAsyncTask;
			 loginResult = Secure2Key.authLogin(idValue, pwValue);


			 
			idValue = null;
			pwValue = null;

			 

			if (loginResult != null)
			{
				if (loginResult.Equals("OKAY"))
				{
					resultOkay();
				}
				else if (loginResult.Equals("NR"))
				{
					DisplayAlert("Error", "ID is unregistered", "OK");
					 
				}
				else if (loginResult.Equals("NA"))
				{
					DisplayAlert("Error", "ID is not available", "OK");

 				}
				else if (loginResult.Equals("EX"))
				{
					DisplayAlert("Error", "Login Error", "OK");
					 
				}
				else if (loginResult.Equals("ES"))
				{
					DisplayAlert("Error", "Login Error", "OK");
 				}
				else if (loginResult.Equals("FAIL_l"))
				{
					DisplayAlert("Error", "Login Error", "OK");
				}
				else if (loginResult.Equals("FAIL_s"))
				{
					DisplayAlert("Error", "Login Error", "OK");
				}
				else if (loginResult.Equals("PW"))
				{
					DisplayAlert("Error", "Incorrect Password", "OK");
				}
				else if (loginResult.Equals("AR"))
				{
					//					dialogSingle("이미 사용중인 아이디입니다.");
					DisplayAlert("Error", "ID is already in use, please press the reset button below. This is to protect the end user", "OK");
 				}
				else
				{
					DisplayAlert("Error", "Login Error", "OK");
				}
			}
		}

		private void resultOkay()
		{

		}
	}
}

