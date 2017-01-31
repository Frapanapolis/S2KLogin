using System;
using Xamarin.Forms;
using Xamarin.Android;
using Android.Content;
using Java.Util;
using Android.Provider;
using Android.Telephony;
using S2KLogin;


[assembly: Dependency(typeof(UUIDInterface))]
namespace S2KLogin.Droid
{
	 
	public class UUID_Android : UUIDInterface
	{
		protected static UUID uuid ;
 
		protected static String id = uuid.ToString();

		public String ID()
		{
			return id;
		}

}
}
