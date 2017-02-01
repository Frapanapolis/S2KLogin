using System;
using System.Runtime.InteropServices;
using Xamarin.Forms;
using S2KLogin;

namespace S2KLogin.iOS
{
	public static class S2KiOS
	{
		 


		 [DllImport("__Internal")]
		public extern static IntPtr authLogin(String jarg1, String jarg2);

		[DllImport("__Internal")]
		public extern static IntPtr authDeviceRegister(String jarg1);

		[DllImport("__Internal")]
		public extern static IntPtr authRegisterConfirm();

		[DllImport("__Internal")]
		public extern static IntPtr requestWholeData(String jarg1, String jarg2);

		[DllImport("__Internal")]
		public extern static IntPtr requestUserConfirm(int jarg1);

		[DllImport("__Internal")]
		public extern static IntPtr requestLatestPushData();

		[DllImport("__Internal")]
		public extern static void clearInternalData();

		[DllImport("__Internal")]
		public extern static IntPtr isAvailable();

		[DllImport("__Internal")]
		public extern static void writePassword(String jarg1);

		[DllImport("__Internal")]
		public extern static IntPtr comparePassword(String jarg1);

		[DllImport("__Internal")]
		public extern static IntPtr readPassword();

		[DllImport("__Internal")]
		public extern static IntPtr readIsPWOn();

		[DllImport("__Internal")]
		public extern static void writeIsPWOn(int jarg1);

		[DllImport("__Internal")]
		public extern static IntPtr refreshData(String jarg1);

		[DllImport("__Internal")]
		public extern static IntPtr getEncData();

		[DllImport("__Internal")]
		public extern static IntPtr writeModeChange(int jarg1);

		[DllImport("__Internal")]
		public extern static IntPtr readMode();

		[DllImport("__Internal")]
		public extern static IntPtr userConfirmType2(String jarg1, String jarg2);

		[DllImport("__Internal")]
		public extern static IntPtr remains();

		[DllImport("__Internal")]
		public extern static IntPtr enterUUID(String jarg1);

		[DllImport("__Internal")]
		public extern static IntPtr call_registerDeviceAndUserInfo(String jarg1, String jarg2, String jarg3, String jarg4);

		[DllImport("__Internal")]
		public extern static IntPtr call_registerFinAccountCard(String jarg1, String jarg2);

		[DllImport("__Internal")]
		public extern static IntPtr requestResignDevice();

		[DllImport("__Internal")]
		public extern static IntPtr registerContentOfEFT(String jarg1, String jarg2, String jarg3, String jarg4, String jarg5, String jarg6);

		[DllImport("__Internal")]
		public extern static IntPtr requestListOfEFT(String jarg1);

		[DllImport("__Internal")]
		public extern static IntPtr registerPurchaseData(String jarg1, String jarg2, String jarg3);

		[DllImport("__Internal")]
		public extern static IntPtr requestStateOfFinAccountCard(String jarg1, String jarg2);

		[DllImport("__Internal")]
		public extern static IntPtr requestEFTSuggestion();

		[DllImport("__Internal")]
		public extern static IntPtr requestChangeEFTName(String jarg1, String jarg2, String jarg3);

		[DllImport("__Internal")]
		public extern static IntPtr registerIABState(String jarg1, String jarg2);

		[DllImport("__Internal")]
		public extern static IntPtr requestResignService();

		[DllImport("__Internal")]
		public extern static IntPtr requestRegisteredFinAccountCard();

		[DllImport("__Internal")]
		public extern static IntPtr requestUnregisterFinAccountCard(String jarg1, String jarg2, String jarg3);

		[DllImport("__Internal")]
		public extern static IntPtr registerUserMessage(String jarg1);

		[DllImport("__Internal")]
		public extern static IntPtr requestUserMessageList();

		[DllImport("__Internal")]
		public extern static IntPtr registerDeviceChange(String jarg1, String jarg2, String jarg3);

		[DllImport("__Internal")]
		public extern static IntPtr makeSignSession();

		[DllImport("__Internal")]
		public extern static IntPtr registerDeviceInfo();

		[DllImport("__Internal")]
		public extern static IntPtr pc_registerDeviceChange(String jarg1, String jarg2, String jarg3);


		[DllImport("__Internal")]
		public extern static IntPtr pc_requestTempPassword(String jarg1, String jarg2, String jarg3);

		[DllImport("__Internal")]
		public extern static IntPtr pc_registerDeviceAndUserInfo(String jarg1, String jarg2, String jarg3, String jarg4, String jarg5, String jarg6);

		[DllImport("__Internal")]
		public extern static IntPtr pc_requestRegisteredList();

		[DllImport("__Internal")]
		public extern static IntPtr pc_registerPCState(String jarg1, String jarg2, String jarg3);

		[DllImport("__Internal")]
		public extern static IntPtr pc_requestNoticeList();

		[DllImport("__Internal")]
		public extern static IntPtr pc_requestQNAList();

		[DllImport("__Internal")]
		public extern static IntPtr pc_registerQuestion(String jarg1);

		[DllImport("__Internal")]
		public extern static IntPtr pc_requestLatestVersion();

		[DllImport("__Internal")]
		public extern static IntPtr pc_requestReleaseDevice();

		[DllImport("__Internal")]
		public extern static IntPtr pc_brokeService(String jarg1, String jarg2);

		[DllImport("__Internal")]
		public extern static IntPtr readUserInfo();

	}

}