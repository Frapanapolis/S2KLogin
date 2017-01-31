using System;
using Xamarin.Forms;
using S2KLogin;
namespace S2KLogin
{
	public class Secure2Key
	{
		 public static String authLogin(String userID, String userPW)
		{
			return DependencyService.Get<S2KInterface>().authLogin(userID, userPW);
		}

		public static String authDeviceRegister(String pushID)
		{
			return DependencyService.Get<S2KInterface>().authDeviceRegister(pushID);
		}

		public static String authRegisterConfirm()
		{
			return DependencyService.Get<S2KInterface>().authRegisterConfirm();

		}

		public static String requestWholeData(String pushData0, String pushData1)
		{
			return DependencyService.Get<S2KInterface>().requestWholeData(pushData0, pushData1);
		}

		public static String requestUserConfirm(int confirm)
		{
			return DependencyService.Get<S2KInterface>().requestUserConfirm(confirm);
		}

		public static String requestLatestPushData()
		{
			return DependencyService.Get<S2KInterface>().requestLatestPushData();
		}

		public static void clearInternalData()
		{
			DependencyService.Get<S2KInterface>().clearInternalData();
		}

		public static String isAvailable()
		{
			return DependencyService.Get<S2KInterface>().isAvailable();
		}

		public static void writePassword(String password)
		{
			DependencyService.Get<S2KInterface>().writePassword(password);
		}

		public static String comparePassword(String password)
		{
			return DependencyService.Get<S2KInterface>().comparePassword(password);
		}

		public static String readPassword()
		{
			return DependencyService.Get<S2KInterface>().readPassword();
		}

		public static String readIsPWOn()
		{
			return DependencyService.Get<S2KInterface>().readIsPWOn();
		}

		public static void writeIsPWOn(int isOn)
		{
			DependencyService.Get<S2KInterface>().writeIsPWOn(isOn);
		}

		public static String refreshData(String encData)
		{
			return DependencyService.Get<S2KInterface>().refreshData(encData);
		}

		public static String getEncData()
		{
			return DependencyService.Get<S2KInterface>().getEncData();
		}

		public static String writeModeChange(int mode)
		{
			return DependencyService.Get<S2KInterface>().writeModeChange(mode);
		}

		public static String readMode()
		{
			return DependencyService.Get<S2KInterface>().readMode();
		}

		public static String userConfirmType2(String countNumber, String minute)
		{
			return DependencyService.Get<S2KInterface>().userConfirmType2(countNumber, minute);
		}

		public static String remains()
		{
			return DependencyService.Get<S2KInterface>().remains();
		}

		public static String enterUUID(String uuid)
		{
			return DependencyService.Get<S2KInterface>().enterUUID(uuid);
		}

		public static String call_registerDeviceAndUserInfo(String userID, String userPW, String pushID, String authCode)
		{
			return DependencyService.Get<S2KInterface>().call_registerDeviceAndUserInfo(userID, userPW, pushID, authCode);
		}

		public static String call_registerFinAccountCard(String authCode, String type)
		{
			return DependencyService.Get<S2KInterface>().call_registerFinAccountCard(authCode, type);
		}

		public static String requestResignDevice()
		{
			return DependencyService.Get<S2KInterface>().requestResignDevice();
		}

		public static String registerContentOfEFT(String day, String name, String begin, String end, String number, String type)
		{
			return DependencyService.Get<S2KInterface>().registerContentOfEFT(day, name, begin, end, number, type);
		}

		public static String requestListOfEFT(String type)
		{
			return DependencyService.Get<S2KInterface>().requestListOfEFT(type);
		}

		public static String registerPurchaseData(String responseCode, String inAppPurchaseData, String inAppDataSignature)
		{
			return DependencyService.Get<S2KInterface>().registerPurchaseData(responseCode, inAppPurchaseData, inAppDataSignature);
		}

		public static String requestStateOfFinAccountCard(String registerCode, String type)
		{
			return DependencyService.Get<S2KInterface>().requestStateOfFinAccountCard(registerCode, type);
		}

		public static String requestEFTSuggestion()
		{
			return DependencyService.Get<S2KInterface>().requestEFTSuggestion();
		}

		public static String requestChangeEFTName(String name, String change, String regTime)
		{
			return DependencyService.Get<S2KInterface>().requestChangeEFTName(name, change, regTime);
		}

		public static String registerIABState(String count, String premiumCount)
		{
			return DependencyService.Get<S2KInterface>().registerIABState(count, premiumCount);
		}

		public static String requestResignService()
		{
			return DependencyService.Get<S2KInterface>().requestResignService();
		}

		public static String requestRegisteredFinAccountCard()
		{
			return DependencyService.Get<S2KInterface>().requestRegisteredFinAccountCard();
		}

		public static String requestUnregisterFinAccountCard(String number, String date, String type)
		{
			return DependencyService.Get<S2KInterface>().requestUnregisterFinAccountCard(number, date, type);
		}

		public static String registerUserMessage(String message)
		{
			return DependencyService.Get<S2KInterface>().registerUserMessage(message);
		}

		public static String requestUserMessageList()
		{
			return DependencyService.Get<S2KInterface>().requestUserMessageList();
		}

		public static String registerDeviceChange(String userID, String userPW, String authCode)
		{
			return DependencyService.Get<S2KInterface>().registerDeviceChange(userID, userPW, authCode);
		}

		public static String makeSignSession()
		{
			return DependencyService.Get<S2KInterface>().makeSignSession();
		}

		public static String registerDeviceInfo()
		{
			return DependencyService.Get<S2KInterface>().registerDeviceInfo();
		}

		public static String pc_registerDeviceChange(String userID, String userPW, String authCode)
		{
			return DependencyService.Get<S2KInterface>().pc_registerDeviceChange(userID, userPW, authCode);
		}

		public static String pc_requestTempPassword(String userID, String authCode, String email)
		{
			return DependencyService.Get<S2KInterface>().pc_requestTempPassword(userID, authCode, email);
		}

		public static String pc_registerDeviceAndUserInfo(String userID, String userPW, String authCode, String email, String agree, String pushID)
		{
			return DependencyService.Get<S2KInterface>().pc_registerDeviceAndUserInfo(userID, userPW, authCode, email, agree, pushID);
		}

		public static String pc_requestRegisteredList()
		{
			return DependencyService.Get<S2KInterface>().pc_requestRegisteredList();
		}

		public static String pc_registerPCState(String targetType, String targetInfo, String state)
		{
			return DependencyService.Get<S2KInterface>().pc_registerPCState(targetType, targetInfo, state);
		}

		public static String pc_requestNoticeList()
		{
			return DependencyService.Get<S2KInterface>().pc_requestNoticeList();
		}

		public static String pc_requestQNAList()
		{
			return DependencyService.Get<S2KInterface>().pc_requestQNAList();
		}

		public static String pc_registerQuestion(String message)
		{
			return DependencyService.Get<S2KInterface>().pc_registerQuestion(message);
		}

		public static String pc_requestLatestVersion()
		{
			return DependencyService.Get<S2KInterface>().pc_requestLatestVersion();
		}

		public static String pc_requestReleaseDevice()
		{
			return DependencyService.Get<S2KInterface>().pc_requestReleaseDevice();
		}

		public static String pc_brokeService(String pushID, String authCode)
		{
			return DependencyService.Get<S2KInterface>().pc_brokeService(pushID, authCode);
		}

		public static String readUserInfo()
		{
			return DependencyService.Get<S2KInterface>().readUserInfo();
		}
			

	}
}
