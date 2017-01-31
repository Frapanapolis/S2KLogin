using System;
namespace S2KLogin.iOS
{
	public class DeviceUuidFactory
	{

		String Uuid = UIKit.UIDevice.CurrentDevice.IdentifierForVendor.AsString();
	}
}
