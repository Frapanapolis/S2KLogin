using System;
using System.Runtime.InteropServices;
using Xamarin.Forms;
 


namespace S2KLogin.Android
{
	public class S2K_Android  
		 
		{
		

			[DllImport("libs2kJNI.so")]
		public extern static String authLogin(String jarg1, String jarg2);
		 
	}
}
