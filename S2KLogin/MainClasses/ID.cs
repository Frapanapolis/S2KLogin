using System;
using Xamarin.Forms;

namespace S2KLogin
{
	public class ID
	{

		public static String getID()
		{
			return DependencyService.Get<UUIDInterface>().ID();
		}
	}
}
