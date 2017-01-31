using System;
using Xamarin.Forms;
using S2KLogin;
using Mono;


 
namespace S2KLogin.iOS
{


	public class UUID_iOS : UUIDInterface
	{
		protected static Guid guid;

		protected static String id = guid.ToString();

		public String ID()
		{
			return id;
		}

					 
		 
	}
}
