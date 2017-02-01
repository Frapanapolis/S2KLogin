using System;
using S2KLogin.Helpers;
using uPLibrary.Networking.M2Mqtt;
namespace S2KLogin
{
	public class MainActivity
	{
		public MainActivity()
		{
			  MqttClient client;
			  string brokerURL = "tcp://68.71.11.18:1883";
			System.ip
			string clientId = "";
			MqttSslUtility.
			              client = new MqttClient(brokerURL,;

			DeviceUuidFactory uuidFactory = new DeviceUuidFactory();
			String uuidString = ID.getID();
			if ((uuidString != null) && (0 < uuidString.Length))
			{
				if ((StaticValues.UUID != null) && !(0 < StaticValues.UUID.Length))
				{
					StaticValues.UUID = uuidString;
				}
			}

			Secure2Key.clearInternalData();
			Secure2Key.enterUUID(StaticValues.UUID);

			String encData = Settings.Data;

			if (0 < encData.Length)
			{
				Secure2Key.refreshData(encData);
			}

			loginCheck();
 		 

		}
		 
		private void loginCheck()
		{
			//SharedPreferences pref = getSharedPreferences(StaticValues.Info,MODE_PRIVATE);
			//String logResult = pref.getString(StaticValues.LogResult, "");
			//String registerResult = pref.getString(StaticValues.RegisterResult, "");
			//System.out.println("loginCheck() in MainActivity if 이전에 -----> "+logResult + " " + registerResult);


			String registerResult = Secure2Key.isAvailable();

			//		System.out.println("registerResult in MainActivity 는 " + registerResult);

			if (registerResult != null)
			{
				if (registerResult.Equals("OKAY"))
				{
					 
				}else{
 
 				}
			}
		}


	}
}
