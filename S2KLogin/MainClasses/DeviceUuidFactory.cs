using System;
using S2KLogin.Helpers;
using Xamarin.Forms;
 
  namespace S2KLogin
{
	public class DeviceUuidFactory
	{
		 
		protected static string uuid;

 		public DeviceUuidFactory()
		{
			 
 
			if (uuid == null)
			{
				lock(this) {
                if( uuid == null) {
                     

						String id = Settings.deviceid;

                    if (id != null) {
                         

							uuid = id;

                    } else {


							Settings.deviceid = ID.getID();

                    }

                }
            }
        }
				 
			}
		}
	 
}