using System;
using System.Runtime.InteropServices;
using Xamarin.Forms;
using S2KLogin.Droid;

[assembly: Dependency(typeof(S2KDependency))]

namespace S2KLogin.Droid
{


	public class S2KDependency: S2KInterface
	{
		 
		public String authLogin(String userID, String userPW)
		{
			return Marshal.PtrToStringAnsi(S2KDroid.authLogin(userID, userPW));
		}

		public String authDeviceRegister(String pushID)
		{
			return Marshal.PtrToStringAnsi(S2KDroid.authDeviceRegister(pushID));
		}

		public String authRegisterConfirm()
		{
			return Marshal.PtrToStringAnsi(S2KDroid.authRegisterConfirm());

		}

		public String requestWholeData(String pushData0, String pushData1)
		{
			return Marshal.PtrToStringAnsi(S2KDroid.requestWholeData(pushData0, pushData1));
		}

		public String requestUserConfirm(int confirm)
		{
			return Marshal.PtrToStringAnsi(S2KDroid.requestUserConfirm(confirm));
		}

		public String requestLatestPushData()
		{
			return Marshal.PtrToStringAnsi(S2KDroid.requestLatestPushData());
		}

		public void clearInternalData()
		{
			S2KDroid.clearInternalData();
		}

		public String isAvailable()
		{
			return Marshal.PtrToStringAnsi(S2KDroid.isAvailable());
		}

		public void writePassword(String password)
		{
			S2KDroid.writePassword(password);
		}

		public String comparePassword(String password)
		{
			return Marshal.PtrToStringAnsi(S2KDroid.comparePassword(password));
		}

		public String readPassword()
		{
			return Marshal.PtrToStringAnsi(S2KDroid.readPassword());
		}

		public String readIsPWOn()
		{
			return Marshal.PtrToStringAnsi(S2KDroid.readIsPWOn());
		}

		public void writeIsPWOn(int isOn)
		{
			S2KDroid.writeIsPWOn(isOn);
		}

		public String refreshData(String encData)
		{
			return Marshal.PtrToStringAnsi(S2KDroid.refreshData(encData));
		}

		public String getEncData()
		{
			return Marshal.PtrToStringAnsi(S2KDroid.getEncData());
		}

		public String writeModeChange(int mode)
		{
			return Marshal.PtrToStringAnsi(S2KDroid.writeModeChange(mode));
		}

		public String readMode()
		{
			return Marshal.PtrToStringAnsi(S2KDroid.readMode());
		}

		public String userConfirmType2(String countNumber, String minute)
		{
			return Marshal.PtrToStringAnsi(S2KDroid.userConfirmType2(countNumber, minute));
		}

		public String remains()
		{
			return Marshal.PtrToStringAnsi(S2KDroid.remains());
		}

		public String enterUUID(String uuid)
		{
			return Marshal.PtrToStringAnsi(S2KDroid.enterUUID(uuid));
		}

		public String call_registerDeviceAndUserInfo(String userID, String userPW, String pushID, String authCode)
		{
			return Marshal.PtrToStringAnsi(S2KDroid.call_registerDeviceAndUserInfo(userID, userPW, pushID, authCode));
		}

		public String call_registerFinAccountCard(String authCode, String type)
		{
			return Marshal.PtrToStringAnsi(S2KDroid.call_registerFinAccountCard(authCode, type));
		}

		public String requestResignDevice()
		{
			return Marshal.PtrToStringAnsi(S2KDroid.requestResignDevice());
		}

		public String registerContentOfEFT(String day, String name, String begin, String end, String number, String type)
		{
			return Marshal.PtrToStringAnsi(S2KDroid.registerContentOfEFT(day, name, begin, end, number, type));
		}

		public String requestListOfEFT(String type)
		{
			return Marshal.PtrToStringAnsi(S2KDroid.requestListOfEFT(type));
		}

		public String registerPurchaseData(String responseCode, String inAppPurchaseData, String inAppDataSignature)
		{
			return Marshal.PtrToStringAnsi(S2KDroid.registerPurchaseData(responseCode, inAppPurchaseData, inAppDataSignature));
		}

		public String requestStateOfFinAccountCard(String registerCode, String type)
		{
			return Marshal.PtrToStringAnsi(S2KDroid.requestStateOfFinAccountCard(registerCode, type));
		}

		public String requestEFTSuggestion()
		{
			return Marshal.PtrToStringAnsi(S2KDroid.requestEFTSuggestion());
		}

		public String requestChangeEFTName(String name, String change, String regTime)
		{
			return Marshal.PtrToStringAnsi(S2KDroid.requestChangeEFTName(name, change, regTime));
		}

		public String registerIABState(String count, String premiumCount)
		{
			return Marshal.PtrToStringAnsi(S2KDroid.registerIABState(count, premiumCount));
		}

		public String requestResignService()
		{
			return Marshal.PtrToStringAnsi(S2KDroid.requestResignService());
		}

		public String requestRegisteredFinAccountCard()
		{
			return Marshal.PtrToStringAnsi(S2KDroid.requestRegisteredFinAccountCard();
		}

		public String requestUnregisterFinAccountCard(String number, String date, String type)
		{
			return Marshal.PtrToStringAnsi(S2KDroid.requestUnregisterFinAccountCard(number, date, type));
		}

		public String registerUserMessage(String message)
		{
			return Marshal.PtrToStringAnsi(S2KDroid.registerUserMessage(message));
		}

		public String requestUserMessageList()
		{
			return Marshal.PtrToStringAnsi(S2KDroid.requestUserMessageList());
		}

		public String registerDeviceChange(String userID, String userPW, String authCode)
		{
			return Marshal.PtrToStringAnsi(S2KDroid.registerDeviceChange(userID, userPW, authCode));
		}

		public String makeSignSession()
		{
			return Marshal.PtrToStringAnsi(S2KDroid.makeSignSession());
		}

		public String registerDeviceInfo()
		{
			return Marshal.PtrToStringAnsi(S2KDroid.registerDeviceInfo());
		}

		public String pc_registerDeviceChange(String userID, String userPW, String authCode)
		{
			return Marshal.PtrToStringAnsi(S2KDroid.pc_registerDeviceChange(userID, userPW, authCode));
		}

		public String pc_requestTempPassword(String userID, String authCode, String email)
		{
			return Marshal.PtrToStringAnsi( S2KDroid.pc_requestTempPassword(userID, authCode, email));
		}

		public String pc_registerDeviceAndUserInfo(String userID, String userPW, String authCode, String email, String agree, String pushID)
		{
			return Marshal.PtrToStringAnsi(S2KDroid.pc_registerDeviceAndUserInfo(userID, userPW, authCode, email, agree, pushID));
		}

		public String pc_requestRegisteredList()
		{
			return Marshal.PtrToStringAnsi(S2KDroid.pc_requestRegisteredList());
		}

		public String pc_registerPCState(String targetType, String targetInfo, String state)
		{
			return Marshal.PtrToStringAnsi(S2KDroid.pc_registerPCState(targetType, targetInfo, state));
		}

		public String pc_requestNoticeList()
		{
			return Marshal.PtrToStringAnsi(S2KDroid.pc_requestNoticeList());
		}

		public String pc_requestQNAList()
		{
			return Marshal.PtrToStringAnsi(S2KDroid.pc_requestQNAList());
		}

		public String pc_registerQuestion(String message)
		{
			return Marshal.PtrToStringAnsi(S2KDroid.pc_registerQuestion(message));
		}

		public String pc_requestLatestVersion()
		{
			return Marshal.PtrToStringAnsi(S2KDroid.pc_requestLatestVersion();
		}

		public String pc_requestReleaseDevice()
		{
			return Marshal.PtrToStringAnsi(S2KDroid.pc_requestReleaseDevice());
		}

		public String pc_brokeService(String pushID, String authCode)
		{
			return Marshal.PtrToStringAnsi(S2KDroid.pc_brokeService(pushID, authCode));
		}

		public String readUserInfo()
		{
			return Marshal.PtrToStringAnsi(S2KDroid.readUserInfo());
		}
	}
}
