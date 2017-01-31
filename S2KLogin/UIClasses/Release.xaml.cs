using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace S2KLogin
{
	public partial class Release : ContentPage
	{
		String userID, userPW;
		public Release()
		{


			InitializeComponent();
			 

		}

		 public void Push_Sound(object sender, EventArgs args)
		{
			 
			userID = IDEntry.Text;
			userPW = PWEntry.Text;

				if (userID.Length < 4 || userPW.Length < 4)
				{
				DisplayAlert("Error", "The ID or Password is incorrect", "OK");
					return;
				}

				 
			 
		}


		public void ReleaseTask()
		{
			String resultAsyncTask;
			resultAsyncTask = Secure2Key.pc_registerDeviceChange(userID, userPW, StaticValues.reqNumber);








			if (resultAsyncTask.Contains("FAIL"))
			{
				DisplayAlert("Error", "Please try again", "OK");

			}
			else
			{
				String resultValue = "";
				try
				{
					var returnJSON = JsonConvert.SerializeObject(new { type = "resultAsyncTask" }, Formatting.None);

				}
				catch (JsonException e)
				{
				}

				if (resultValue.Contains("OKAY"))
				{
					//dialogSingleAndNext("다시 로그인 해주세요");
					DisplayAlert("Success", "Initialization Completed. Enter your ID and Password to use the app normally.", "OK");
 				}
				else
				{
					DisplayAlert("Error", "Please try again", "OK");
				}
			}


		}
		public string jgetString()
		{
			
			//Return json
			return JsonConvert.SerializeObject(this);
		}
	}
}

