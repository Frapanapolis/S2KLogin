using System;
using System.Runtime.InteropServices;
using Xamarin.Forms;
using S2KLogin;

namespace S2KLogin.Droid
{
	public static class S2KDroid
	{
		  
		[DllImport("s2kJNI", EntryPoint = "authLogin")]
		public extern static IntPtr authLogin(String jarg1, String jarg2);

		[DllImport("s2kJNI")]
		public extern static IntPtr authDeviceRegister(String jarg1);

		[DllImport("s2kJNI")]
		public extern static IntPtr authRegisterConfirm();

		[DllImport("s2kJNI")]
		public extern static IntPtr requestWholeData(String jarg1, String jarg2);

		[DllImport("s2kJNI")]
		public extern static IntPtr requestUserConfirm(int jarg1);

		[DllImport("s2kJNI")]
		public extern static IntPtr requestLatestPushData();

		[DllImport("s2kJNI")]
		public extern static void clearInternalData();

		[DllImport("s2kJNI")]
		public extern static IntPtr isAvailable();

		[DllImport("s2kJNI")]
		public extern static void writePassword(String jarg1);

		[DllImport("s2kJNI")]
		public extern static IntPtr comparePassword(String jarg1);

		[DllImport("s2kJNI")]
		public extern static IntPtr readPassword();

		[DllImport("s2kJNI")]
		public extern static IntPtr readIsPWOn();

		[DllImport("s2kJNI")]
		public extern static void writeIsPWOn(int jarg1);

		[DllImport("s2kJNI")]
		public extern static IntPtr refreshData(String jarg1);

		[DllImport("s2kJNI")]
		public extern static IntPtr getEncData();

		[DllImport("s2kJNI")]
		public extern static IntPtr writeModeChange(int jarg1);

		[DllImport("s2kJNI")]
		public extern static IntPtr readMode();

		[DllImport("s2kJNI")]
		public extern static IntPtr userConfirmType2(String jarg1, String jarg2);

		[DllImport("s2kJNI")]
		public extern static IntPtr remains();

		[DllImport("s2kJNI")]
		public extern static IntPtr enterUUID(String jarg1);

		[DllImport("s2kJNI")]
		public extern static IntPtr call_registerDeviceAndUserInfo(String jarg1, String jarg2, String jarg3, String jarg4);

		[DllImport("s2kJNI")]
		public extern static IntPtr call_registerFinAccountCard(String jarg1, String jarg2);

		[DllImport("s2kJNI")]
		public extern static IntPtr requestResignDevice();

		[DllImport("s2kJNI")]
		public extern static IntPtr registerContentOfEFT(String jarg1, String jarg2, String jarg3, String jarg4, String jarg5, String jarg6);

		[DllImport("s2kJNI")]
		public extern static IntPtr requestListOfEFT(String jarg1);

		[DllImport("s2kJNI")]
		public extern static IntPtr registerPurchaseData(String jarg1, String jarg2, String jarg3);

		[DllImport("s2kJNI")]
		public extern static IntPtr requestStateOfFinAccountCard(String jarg1, String jarg2);

		[DllImport("s2kJNI")]
		public extern static IntPtr requestEFTSuggestion();

		[DllImport("s2kJNI")]
		public extern static IntPtr requestChangeEFTName(String jarg1, String jarg2, String jarg3);

		[DllImport("s2kJNI")]
		public extern static IntPtr registerIABState(String jarg1, String jarg2);

		[DllImport("s2kJNI")]
		public extern static IntPtr requestResignService();

		[DllImport("s2kJNI")]
		public extern static IntPtr requestRegisteredFinAccountCard();

		[DllImport("s2kJNI")]
		public extern static IntPtr requestUnregisterFinAccountCard(String jarg1, String jarg2, String jarg3);

		[DllImport("s2kJNI")]
		public extern static IntPtr registerUserMessage(String jarg1);

		[DllImport("s2kJNI")]
		public extern static IntPtr requestUserMessageList();

		[DllImport("s2kJNI")]
		public extern static IntPtr registerDeviceChange(String jarg1, String jarg2, String jarg3);

		[DllImport("s2kJNI")]
		public extern static IntPtr makeSignSession();

		[DllImport("s2kJNI")]
		public extern static IntPtr registerDeviceInfo();

		[DllImport("s2kJNI")]
		public extern static IntPtr pc_registerDeviceChange(String jarg1, String jarg2, String jarg3);

		[DllImport("s2kJNI", EntryPoint = "pc_requestTempPassword")]
		public extern static IntPtr pc_requestTempPassword(String jarg1, String jarg2, String jarg3);

		[DllImport("s2kJNI")]
		public extern static IntPtr pc_registerDeviceAndUserInfo(String jarg1, String jarg2, String jarg3, String jarg4, String jarg5, String jarg6);

		[DllImport("s2kJNI")]
		public extern static IntPtr pc_requestRegisteredList();

		[DllImport("s2kJNI")]
		public extern static IntPtr pc_registerPCState(String jarg1, String jarg2, String jarg3);

		[DllImport("s2kJNI")]
		public extern static IntPtr pc_requestNoticeList();

		[DllImport("s2kJNI")]
		public extern static IntPtr pc_requestQNAList();

		[DllImport("s2kJNI")]
		public extern static IntPtr pc_registerQuestion(String jarg1);

		[DllImport("s2kJNI")]
		public extern static IntPtr pc_requestLatestVersion();

		[DllImport("s2kJNI")]
		public extern static IntPtr pc_requestReleaseDevice();

		[DllImport("s2kJNI")]
		public extern static IntPtr pc_brokeService(String jarg1, String jarg2);

		[DllImport("s2kJNI")]
		public extern static IntPtr readUserInfo();

	}

}