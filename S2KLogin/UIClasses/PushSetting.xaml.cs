using System;
using System.Collections.Generic;
using S2KLogin.Helpers;
using Xamarin.Forms;

namespace S2KLogin
{
	public partial class PushSetting : ContentPage
	{
		public PushSetting ()
		{
			InitializeComponent ();
		}
		 
		public void Push_Sound(object sender, EventArgs args)
		{
			String state = "ON";

			Settings.Sound = state;


		}

		public void Push_Silence(object sender, EventArgs args)
		{
			String state = "OFF";

			Settings.Sound = state;



		}
		public void Push_Toggle(object sender, EventArgs args)
		{
			String soundState = Settings.Sound;
			String vibrationState = Settings.Vibration;
		 
   			Boolean isOn = false;
			if (soundState.Equals("ON") || vibrationState.Equals("ON")) { isOn = true; }

			String state = "OFF";
			if (isOn) { state = "OFF"; } // on -> off
			else { state = "ON"; } // off -> on
			 
			Settings.Sound = state;


		}

		public void Push_Vibration(object sender, EventArgs args)
		{
			 
			String vibrationState = Settings.Vibration;

			Boolean isOn = false;
			if ( vibrationState.Equals("ON")) { isOn = true; }

			String state = "OFF";
			if (isOn) { state = "OFF"; } // on -> off
			else { state = "ON"; } // off -> on

			Settings.Vibration = state;


		}
 		 
	}
}

