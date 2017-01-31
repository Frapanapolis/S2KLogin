using System;
using System.Runtime.InteropServices;
namespace S2KLogin
{
	public class S2KJni
	{
		 
		[DllImport("libs2kJNI.so")]
		public extern static String authLogin(String jarg1, String jarg2);

		[DllImport("libs2kJNI.so")]
		public extern static   String authDeviceRegister(String jarg1);

		[DllImport("libs2kJNI.so")]
		public extern static   String authRegisterConfirm();

		[DllImport("libs2kJNI.so")]
		public extern static   String requestWholeData(String jarg1, String jarg2);

		[DllImport("libs2kJNI.so")]
		public extern static   String requestUserConfirm(int jarg1);

		[DllImport("libs2kJNI.so")]
		public extern static   String requestLatestPushData();

		[DllImport("libs2kJNI.so")]
		public extern static   void clearInternalData();

		[DllImport("libs2kJNI.so")]
		public extern static   String isAvailable();

		[DllImport("libs2kJNI.so")]
		public extern static   void writePassword(String jarg1);

		[DllImport("libs2kJNI.so")]
		public extern static   String comparePassword(String jarg1);

		[DllImport("libs2kJNI.so")]
		public extern static   String readPassword();

		[DllImport("libs2kJNI.so")]
		public extern static   String readIsPWOn();

		[DllImport("libs2kJNI.so")]
		public extern static   void writeIsPWOn(int jarg1);

		[DllImport("libs2kJNI.so")]
		public extern static   String refreshData(String jarg1);

		[DllImport("libs2kJNI.so")]
		public extern static   String getEncData();

		[DllImport("libs2kJNI.so")]
		public extern static   String writeModeChange(int jarg1);

		[DllImport("libs2kJNI.so")]
		public extern static   String readMode();

		[DllImport("libs2kJNI.so")]
		public extern static   String userConfirmType2(String jarg1, String jarg2);

		[DllImport("libs2kJNI.so")]
		public extern static   String remains();

		[DllImport("libs2kJNI.so")]
		public extern static   String enterUUID(String jarg1);

		[DllImport("libs2kJNI.so")]
		public extern static   String call_registerDeviceAndUserInfo(String jarg1, String jarg2, String jarg3, String jarg4);

		[DllImport("libs2kJNI.so")]
		public extern static   String call_registerFinAccountCard(String jarg1, String jarg2);

		[DllImport("libs2kJNI.so")]
		public extern static   String requestResignDevice();

		[DllImport("libs2kJNI.so")]
		public extern static   String registerContentOfEFT(String jarg1, String jarg2, String jarg3, String jarg4, String jarg5, String jarg6);

		[DllImport("libs2kJNI.so")]
		public extern static   String requestListOfEFT(String jarg1);

		[DllImport("libs2kJNI.so")]
		public extern static   String registerPurchaseData(String jarg1, String jarg2, String jarg3);

		[DllImport("libs2kJNI.so")]
		public extern static   String requestStateOfFinAccountCard(String jarg1, String jarg2);

		[DllImport("libs2kJNI.so")]
		public extern static   String requestEFTSuggestion();

		[DllImport("libs2kJNI.so")]
		public extern static   String requestChangeEFTName(String jarg1, String jarg2, String jarg3);

		[DllImport("libs2kJNI.so")]
		public extern static   String registerIABState(String jarg1, String jarg2);

		[DllImport("libs2kJNI.so")]
		public extern static   String requestResignService();

		[DllImport("libs2kJNI.so")]
		public extern static   String requestRegisteredFinAccountCard();

		[DllImport("libs2kJNI.so")]
		public extern static   String requestUnregisterFinAccountCard(String jarg1, String jarg2, String jarg3);

		[DllImport("libs2kJNI.so")]
		public extern static   String registerUserMessage(String jarg1);

		[DllImport("libs2kJNI.so")]
		public extern static   String requestUserMessageList();

		[DllImport("libs2kJNI.so")]
		public extern static   String registerDeviceChange(String jarg1, String jarg2, String jarg3);

		[DllImport("libs2kJNI.so")]
		public extern static   String makeSignSession();

		[DllImport("libs2kJNI.so")]
		public extern static   String registerDeviceInfo();

		[DllImport("libs2kJNI.so")]
		public extern static   String pc_registerDeviceChange(String jarg1, String jarg2, String jarg3);

		[DllImport("libs2kJNI.so")]
		public extern static   String pc_requestTempPassword(String jarg1, String jarg2, String jarg3);

		[DllImport("libs2kJNI.so")]
		public extern static   String pc_registerDeviceAndUserInfo(String jarg1, String jarg2, String jarg3, String jarg4, String jarg5, String jarg6);

		[DllImport("libs2kJNI.so")]
		public extern static   String pc_requestRegisteredList();

		[DllImport("libs2kJNI.so")]
		public extern static   String pc_registerPCState(String jarg1, String jarg2, String jarg3);

		[DllImport("libs2kJNI.so")]
		public extern static   String pc_requestNoticeList();

		[DllImport("libs2kJNI.so")]
		public extern static   String pc_requestQNAList();
		 
		[DllImport("libs2kJNI.so")]
		public extern static   String pc_registerQuestion(String jarg1);

		[DllImport("libs2kJNI.so")]
		public extern static   String pc_requestLatestVersion();

		[DllImport("libs2kJNI.so")]
		public extern static   String pc_requestReleaseDevice();

		[DllImport("libs2kJNI.so")]
		public extern static   String pc_brokeService(String jarg1, String jarg2);

		[DllImport("libs2kJNI.so")]
		public extern static   String readUserInfo();
		 
	}
}
