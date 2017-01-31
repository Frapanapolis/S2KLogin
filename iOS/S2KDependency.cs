using System;
using System.Runtime.InteropServices;
using Xamarin.Forms;
using S2KLogin.iOS;


[assembly: Dependency(typeof(S2KDependency))]

namespace S2KLogin.iOS
{


	public class S2KDependency: S2KInterface
	{
		 
		public String authLogin(String userID, String userPW)
		{
			return S2KiOS.authLogin(userID, userPW);
		}

		public String authDeviceRegister(String pushID)
		{
			return S2KiOS.authDeviceRegister(pushID);
		}

		public String authRegisterConfirm()
		{
			return S2KiOS.authRegisterConfirm();

		}

		public String requestWholeData(String pushData0, String pushData1)
		{
			return S2KiOS.requestWholeData(pushData0, pushData1);
		}

		public String requestUserConfirm(int confirm)
		{
			return S2KiOS.requestUserConfirm(confirm);
		}

		public String requestLatestPushData()
		{
			return S2KiOS.requestLatestPushData();
		}

		public void clearInternalData()
		{
			S2KiOS.clearInternalData();
		}

		public String isAvailable()
		{
			return S2KiOS.isAvailable();
		}

		public void writePassword(String password)
		{
			S2KiOS.writePassword(password);
		}

		public String comparePassword(String password)
		{
			return S2KiOS.comparePassword(password);
		}

		public String readPassword()
		{
			return S2KiOS.readPassword();
		}

		public String readIsPWOn()
		{
			return S2KiOS.readIsPWOn();
		}

		public void writeIsPWOn(int isOn)
		{
			S2KiOS.writeIsPWOn(isOn);
		}

		public String refreshData(String encData)
		{
			return S2KiOS.refreshData(encData);
		}

		public String getEncData()
		{
			return S2KiOS.getEncData();
		}

		public String writeModeChange(int mode)
		{
			return S2KiOS.writeModeChange(mode);
		}

		public String readMode()
		{
			return S2KiOS.readMode();
		}

		public String userConfirmType2(String countNumber, String minute)
		{
			return S2KiOS.userConfirmType2(countNumber, minute);
		}

		public String remains()
		{
			return S2KiOS.remains();
		}

		public String enterUUID(String uuid)
		{
			return S2KiOS.enterUUID(uuid);
		}

		public String call_registerDeviceAndUserInfo(String userID, String userPW, String pushID, String authCode)
		{
			return S2KiOS.call_registerDeviceAndUserInfo(userID, userPW, pushID, authCode);
		}

		public String call_registerFinAccountCard(String authCode, String type)
		{
			return S2KiOS.call_registerFinAccountCard(authCode, type);
		}

		public String requestResignDevice()
		{
			return S2KiOS.requestResignDevice();
		}

		public String registerContentOfEFT(String day, String name, String begin, String end, String number, String type)
		{
			return S2KiOS.registerContentOfEFT(day, name, begin, end, number, type);
		}

		public String requestListOfEFT(String type)
		{
			return S2KiOS.requestListOfEFT(type);
		}

		public String registerPurchaseData(String responseCode, String inAppPurchaseData, String inAppDataSignature)
		{
			return S2KiOS.registerPurchaseData(responseCode, inAppPurchaseData, inAppDataSignature);
		}

		public String requestStateOfFinAccountCard(String registerCode, String type)
		{
			return S2KiOS.requestStateOfFinAccountCard(registerCode, type);
		}

		public String requestEFTSuggestion()
		{
			return S2KiOS.requestEFTSuggestion();
		}

		public String requestChangeEFTName(String name, String change, String regTime)
		{
			return S2KiOS.requestChangeEFTName(name, change, regTime);
		}

		public String registerIABState(String count, String premiumCount)
		{
			return S2KiOS.registerIABState(count, premiumCount);
		}

		public String requestResignService()
		{
			return S2KiOS.requestResignService();
		}

		public String requestRegisteredFinAccountCard()
		{
			return S2KiOS.requestRegisteredFinAccountCard();
		}

		public String requestUnregisterFinAccountCard(String number, String date, String type)
		{
			return S2KiOS.requestUnregisterFinAccountCard(number, date, type);
		}

		public String registerUserMessage(String message)
		{
			return S2KiOS.registerUserMessage(message);
		}

		public String requestUserMessageList()
		{
			return S2KiOS.requestUserMessageList();
		}

		public String registerDeviceChange(String userID, String userPW, String authCode)
		{
			return S2KiOS.registerDeviceChange(userID, userPW, authCode);
		}

		public String makeSignSession()
		{
			return S2KiOS.makeSignSession();
		}

		public String registerDeviceInfo()
		{
			return S2KiOS.registerDeviceInfo();
		}

		public String pc_registerDeviceChange(String userID, String userPW, String authCode)
		{
			return S2KiOS.pc_registerDeviceChange(userID, userPW, authCode);
		}

		public String pc_requestTempPassword(String userID, String authCode, String email)
		{
			return S2KiOS.pc_requestTempPassword(userID, authCode, email);
		}

		public String pc_registerDeviceAndUserInfo(String userID, String userPW, String authCode, String email, String agree, String pushID)
		{
			return S2KiOS.pc_registerDeviceAndUserInfo(userID, userPW, authCode, email, agree, pushID);
		}

		public String pc_requestRegisteredList()
		{
			return S2KiOS.pc_requestRegisteredList();
		}

		public String pc_registerPCState(String targetType, String targetInfo, String state)
		{
			return S2KiOS.pc_registerPCState(targetType, targetInfo, state);
		}

		public String pc_requestNoticeList()
		{
			return S2KiOS.pc_requestNoticeList();
		}

		public String pc_requestQNAList()
		{
			return S2KiOS.pc_requestQNAList();
		}

		public String pc_registerQuestion(String message)
		{
			return S2KiOS.pc_registerQuestion(message);
		}

		public String pc_requestLatestVersion()
		{
			return S2KiOS.pc_requestLatestVersion();
		}

		public String pc_requestReleaseDevice()
		{
			return S2KiOS.pc_requestReleaseDevice();
		}

		public String pc_brokeService(String pushID, String authCode)
		{
			return S2KiOS.pc_brokeService(pushID, authCode);
		}

		public String readUserInfo()
		{
			return S2KiOS.readUserInfo();
		}
	}
}
