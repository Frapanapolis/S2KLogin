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
			return S2KDroid.authLogin(userID, userPW);
		}

		public String authDeviceRegister(String pushID)
		{
			return S2KDroid.authDeviceRegister(pushID);
		}

		public String authRegisterConfirm()
		{
			return S2KDroid.authRegisterConfirm();

		}

		public String requestWholeData(String pushData0, String pushData1)
		{
			return S2KDroid.requestWholeData(pushData0, pushData1);
		}

		public String requestUserConfirm(int confirm)
		{
			return S2KDroid.requestUserConfirm(confirm);
		}

		public String requestLatestPushData()
		{
			return S2KDroid.requestLatestPushData();
		}

		public void clearInternalData()
		{
			S2KDroid.clearInternalData();
		}

		public String isAvailable()
		{
			return S2KDroid.isAvailable();
		}

		public void writePassword(String password)
		{
			S2KDroid.writePassword(password);
		}

		public String comparePassword(String password)
		{
			return S2KDroid.comparePassword(password);
		}

		public String readPassword()
		{
			return S2KDroid.readPassword();
		}

		public String readIsPWOn()
		{
			return S2KDroid.readIsPWOn();
		}

		public void writeIsPWOn(int isOn)
		{
			S2KDroid.writeIsPWOn(isOn);
		}

		public String refreshData(String encData)
		{
			return S2KDroid.refreshData(encData);
		}

		public String getEncData()
		{
			return S2KDroid.getEncData();
		}

		public String writeModeChange(int mode)
		{
			return S2KDroid.writeModeChange(mode);
		}

		public String readMode()
		{
			return S2KDroid.readMode();
		}

		public String userConfirmType2(String countNumber, String minute)
		{
			return S2KDroid.userConfirmType2(countNumber, minute);
		}

		public String remains()
		{
			return S2KDroid.remains();
		}

		public String enterUUID(String uuid)
		{
			return S2KDroid.enterUUID(uuid);
		}

		public String call_registerDeviceAndUserInfo(String userID, String userPW, String pushID, String authCode)
		{
			return S2KDroid.call_registerDeviceAndUserInfo(userID, userPW, pushID, authCode);
		}

		public String call_registerFinAccountCard(String authCode, String type)
		{
			return S2KDroid.call_registerFinAccountCard(authCode, type);
		}

		public String requestResignDevice()
		{
			return S2KDroid.requestResignDevice();
		}

		public String registerContentOfEFT(String day, String name, String begin, String end, String number, String type)
		{
			return S2KDroid.registerContentOfEFT(day, name, begin, end, number, type);
		}

		public String requestListOfEFT(String type)
		{
			return S2KDroid.requestListOfEFT(type);
		}

		public String registerPurchaseData(String responseCode, String inAppPurchaseData, String inAppDataSignature)
		{
			return S2KDroid.registerPurchaseData(responseCode, inAppPurchaseData, inAppDataSignature);
		}

		public String requestStateOfFinAccountCard(String registerCode, String type)
		{
			return S2KDroid.requestStateOfFinAccountCard(registerCode, type);
		}

		public String requestEFTSuggestion()
		{
			return S2KDroid.requestEFTSuggestion();
		}

		public String requestChangeEFTName(String name, String change, String regTime)
		{
			return S2KDroid.requestChangeEFTName(name, change, regTime);
		}

		public String registerIABState(String count, String premiumCount)
		{
			return S2KDroid.registerIABState(count, premiumCount);
		}

		public String requestResignService()
		{
			return S2KDroid.requestResignService();
		}

		public String requestRegisteredFinAccountCard()
		{
			return S2KDroid.requestRegisteredFinAccountCard();
		}

		public String requestUnregisterFinAccountCard(String number, String date, String type)
		{
			return S2KDroid.requestUnregisterFinAccountCard(number, date, type);
		}

		public String registerUserMessage(String message)
		{
			return S2KDroid.registerUserMessage(message);
		}

		public String requestUserMessageList()
		{
			return S2KDroid.requestUserMessageList();
		}

		public String registerDeviceChange(String userID, String userPW, String authCode)
		{
			return S2KDroid.registerDeviceChange(userID, userPW, authCode);
		}

		public String makeSignSession()
		{
			return S2KDroid.makeSignSession();
		}

		public String registerDeviceInfo()
		{
			return S2KDroid.registerDeviceInfo();
		}

		public String pc_registerDeviceChange(String userID, String userPW, String authCode)
		{
			return S2KDroid.pc_registerDeviceChange(userID, userPW, authCode);
		}

		public String pc_requestTempPassword(String userID, String authCode, String email)
		{
			return S2KDroid.pc_requestTempPassword(userID, authCode, email);
		}

		public String pc_registerDeviceAndUserInfo(String userID, String userPW, String authCode, String email, String agree, String pushID)
		{
			return S2KDroid.pc_registerDeviceAndUserInfo(userID, userPW, authCode, email, agree, pushID);
		}

		public String pc_requestRegisteredList()
		{
			return S2KDroid.pc_requestRegisteredList();
		}

		public String pc_registerPCState(String targetType, String targetInfo, String state)
		{
			return S2KDroid.pc_registerPCState(targetType, targetInfo, state);
		}

		public String pc_requestNoticeList()
		{
			return S2KDroid.pc_requestNoticeList();
		}

		public String pc_requestQNAList()
		{
			return S2KDroid.pc_requestQNAList();
		}

		public String pc_registerQuestion(String message)
		{
			return S2KDroid.pc_registerQuestion(message);
		}

		public String pc_requestLatestVersion()
		{
			return S2KDroid.pc_requestLatestVersion();
		}

		public String pc_requestReleaseDevice()
		{
			return S2KDroid.pc_requestReleaseDevice();
		}

		public String pc_brokeService(String pushID, String authCode)
		{
			return S2KDroid.pc_brokeService(pushID, authCode);
		}

		public String readUserInfo()
		{
			return S2KDroid.readUserInfo();
		}
	}
}
