﻿using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Mono;
namespace S2KLogin.iOS
{
	public class Application
	{
		// This is the main entry point of the application.
		static void Main(string[] args)
		{
			// if you want to use a different Application Delegate class from "AppDelegate"
			// you can specify it here.
			  
 			ObjCRuntime.Dlfcn.dlopen("/lib/armeabi/libs2k.dylib", 0);
 			UIApplication.Main(args, null, "AppDelegate");
		}
	}
}