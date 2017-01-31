using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using S2KLogin.Helpers;
using Xamarin.Forms;
using S2KLogin; 
using System.Text;
namespace S2KLogin
{
	public partial class SignUp : ContentPage
	{
		Boolean isReceiveOK;

		static String enter_id;
		static String enter_pw;
		static String enter_pw2;
		static String enter_email;
		static String enter_emailCompany;
		static String agree;


		public SignUp ()
		{
			InitializeComponent ();
			 

			//CompanyEntry.TextChanged += (sender, args) =>
			//{
			//	EmailPicker.SelectedIndex = -1;
			//};

			//EmailPicker.SelectedIndexChanged += (sender, args) => { CompanyEntry.Text = null; };



		}


		public static bool EmailIsValid(string email)
		{
			return Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
		}


		public void SignUP(object sender, EventArgs args)
		{
			 
				enter_id = IDEntry.Text;
				enter_pw = PWEntry.Text;
				enter_pw2 = PWConfirmEntry.Text;

				String tempEmail = CompanyEntry.Text;
				if (tempEmail.Length < 4)
				{
					enter_emailCompany = EmailPicker.Items[EmailPicker.SelectedIndex];

				}
				else
				{
					enter_emailCompany = CompanyEntry.Text;

				}


				enter_email = EmailEntry.Text;



				isReceiveOK = EmailSwitch.IsToggled;
				if (isReceiveOK)
				{
					agree = "1";

				}
				else
				{
					agree = "0";

				}

				if ((enter_id.Length < 4) | (String.IsNullOrEmpty(enter_id))) { DisplayAlert("Error", "The ID is too short", "OK"); return; }
				else if ((enter_pw.Length < 4) | (String.IsNullOrEmpty(enter_id))) { DisplayAlert("Error", "The Password is too short", "OK"); return; }
				else if ((enter_pw2.CompareTo(enter_pw) != 0) | (String.IsNullOrEmpty(enter_pw2)) | (String.IsNullOrEmpty(enter_pw))) { DisplayAlert("Error", "Passwords do not match", "OK"); return; }
				//				else if( isReceiveOK && ( (enter_email.length() <= 0) || (enter_emailCompany.length() <= 0) ) )
				//				{
				//					dialogSingle("이메일이 올바르지 않습니다.");
				//				}
				else if (!EmailIsValid(enter_email + "@" + enter_emailCompany))
				{
					DisplayAlert("Error", "Email provided in not valid", "OK");
					 
					return;
				}

			}

		 
		private void SignUpTask()
	{
			String resultAsyncTask;
		 
			String tempEmail = enter_email + "@" + enter_emailCompany;
			byte[] emailBytes = Encoding.UTF8.GetBytes(tempEmail);
			String hexedEmail = bytesToHex(emailBytes);
			resultAsyncTask = Secure2Key.pc_registerDeviceAndUserInfo(enter_id, enter_pw, StaticValues.reqNumber, hexedEmail, agree, StaticValues.RegistrationId);

		 
			if (resultAsyncTask.Contains("FAIL"))
			{
				DisplayAlert("Error", "Please Try Again", "OK");
			}
			else
			{
				if (resultAsyncTask.CompareTo("OKAY") == 0)
				{
					makeSession();
				}
				else if (resultAsyncTask.CompareTo("AR") == 0)
				{
					DisplayAlert("Error", "ID is alrady in use", "OK");
				}
				else if (resultAsyncTask.CompareTo("FAIL") == 0)
				{
					DisplayAlert("Error", "Registration Error", "OK");
				}
				else
				{
					DisplayAlert("Error", "Registration Error", "OK");

				}
			}
		}

		private void makeSession()
		{

			String resultString;

			resultString = Secure2Key.makeSignSession();
			if (resultString.Contains("FINISH"))
			{
				registerDevice();
			}
			else
			{
				DisplayAlert("Error", "Registration Error", "OK");

			}

			return;


		}

 		private void registerDevice ()
		{


		  String resultRegisterDeviceAsync;
			resultRegisterDeviceAsync = Secure2Key.authDeviceRegister(StaticValues.RegistrationId);
		 

			if (resultRegisterDeviceAsync.Equals("OKAY"))
			{
				// wait continue push
			}
			else
			{
				DisplayAlert("Error", "Registration Error", "OK");
			}

			return;
		}
	 
	//	private   BroadcastReceiver mHandleMessageReceiver = new BroadcastReceiver()
	//	{
	//		@Override
	//	public void onReceive(Context context, Intent intent)
	//	{
	//		String msg = intent.getExtras().getString("msg");

	//		if (msg.equals("continue"))
	//		{
	//			nextActivity();
	//		}
	//		else
	//		{
	//			dialogSingle("Fail_P");
	//		}
	//	}
	//};


	private void ConfirmService()
		{
			String resultRegisterConfirmAsync;
			resultRegisterConfirmAsync = Secure2Key.authRegisterConfirm();
			if (resultRegisterConfirmAsync.Equals("OKAY"))
			{
				registerOkay();
			}
			else
			{
				DisplayAlert("Error", "Please Try Again", "OK");
			}

			return;
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

			DisplayAlert("Notice", "Defalut App Password is 0000.", "OK");

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

