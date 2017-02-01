using System;
using System.Runtime.InteropServices;
using Xamarin.Forms;
using S2KLogin.iOS;
using System.Text;

[assembly: Dependency(typeof(S2KDependency))]

namespace S2KLogin.iOS
{


	public class S2KDependency:  S2KInterface
	{
		public String authLogin(String userID, String userPW)
		{
			return Marshal.PtrToStringAnsi(S2KiOS.authLogin(userID, userPW));
		}

		public String authDeviceRegister(String pushID)
		{
			return Marshal.PtrToStringAnsi(S2KiOS.authDeviceRegister(pushID));
		}

		public String authRegisterConfirm()
		{
			return Marshal.PtrToStringAnsi(S2KiOS.authRegisterConfirm());

		}

		public String requestWholeData(String pushData0, String pushData1)
		{
			return Marshal.PtrToStringAnsi(S2KiOS.requestWholeData(pushData0, pushData1));
		}

		public String requestUserConfirm(int confirm)
		{
			return Marshal.PtrToStringAnsi(S2KiOS.requestUserConfirm(confirm));
		}

		public String requestLatestPushData()
		{
			return Marshal.PtrToStringAnsi(S2KiOS.requestLatestPushData());
		}

		public void clearInternalData()
		{
			S2KiOS.clearInternalData();
		}

		public String isAvailable()
		{
			return Marshal.PtrToStringAnsi(S2KiOS.isAvailable());
		}

		public void writePassword(String password)
		{
			S2KiOS.writePassword(password);
		}

		public String comparePassword(String password)
		{
			return Marshal.PtrToStringAnsi(S2KiOS.comparePassword(password));
		}

		public String readPassword()
		{
			return Marshal.PtrToStringAnsi(S2KiOS.readPassword());
		}

		public String readIsPWOn()
		{
			return Marshal.PtrToStringAnsi(S2KiOS.readIsPWOn());
		}

		public void writeIsPWOn(int isOn)
		{
			S2KiOS.writeIsPWOn(isOn);
		}

		public String refreshData(String encData)
		{
			return Marshal.PtrToStringAnsi(S2KiOS.refreshData(encData));
		}

		public String getEncData()
		{
			return Marshal.PtrToStringAnsi(S2KiOS.getEncData());
		}

		public String writeModeChange(int mode)
		{
			return Marshal.PtrToStringAnsi(S2KiOS.writeModeChange(mode));
		}

		public String readMode()
		{
			return Marshal.PtrToStringAnsi(S2KiOS.readMode());
		}

		public String userConfirmType2(String countNumber, String minute)
		{
			return Marshal.PtrToStringAnsi(S2KiOS.userConfirmType2(countNumber, minute));
		}

		public String remains()
		{
			return Marshal.PtrToStringAnsi(S2KiOS.remains());
		}

		public String enterUUID(String uuid)
		{
			return Marshal.PtrToStringAnsi(S2KiOS.enterUUID(uuid));
		}

		public String call_registerDeviceAndUserInfo(String userID, String userPW, String pushID, String authCode)
		{
			return Marshal.PtrToStringAnsi(S2KiOS.call_registerDeviceAndUserInfo(userID, userPW, pushID, authCode));
		}

		public String call_registerFinAccountCard(String authCode, String type)
		{
			return Marshal.PtrToStringAnsi(S2KiOS.call_registerFinAccountCard(authCode, type));
		}

		public String requestResignDevice()
		{
			return Marshal.PtrToStringAnsi(S2KiOS.requestResignDevice());
		}

		public String registerContentOfEFT(String day, String name, String begin, String end, String number, String type)
		{
			return Marshal.PtrToStringAnsi(S2KiOS.registerContentOfEFT(day, name, begin, end, number, type));
		}

		public String requestListOfEFT(String type)
		{
			return Marshal.PtrToStringAnsi(S2KiOS.requestListOfEFT(type));
		}

		public String registerPurchaseData(String responseCode, String inAppPurchaseData, String inAppDataSignature)
		{
			return Marshal.PtrToStringAnsi(S2KiOS.registerPurchaseData(responseCode, inAppPurchaseData, inAppDataSignature));
		}

		public String requestStateOfFinAccountCard(String registerCode, String type)
		{
			return Marshal.PtrToStringAnsi(S2KiOS.requestStateOfFinAccountCard(registerCode, type));
		}

		public String requestEFTSuggestion()
		{
			return Marshal.PtrToStringAnsi(S2KiOS.requestEFTSuggestion());
		}

		public String requestChangeEFTName(String name, String change, String regTime)
		{
			return Marshal.PtrToStringAnsi(S2KiOS.requestChangeEFTName(name, change, regTime));
		}

		public String registerIABState(String count, String premiumCount)
		{
			return Marshal.PtrToStringAnsi(S2KiOS.registerIABState(count, premiumCount));
		}

		public String requestResignService()
		{
			return Marshal.PtrToStringAnsi(S2KiOS.requestResignService());
		}

		public String requestRegisteredFinAccountCard()
		{
			return Marshal.PtrToStringAnsi(S2KiOS.requestRegisteredFinAccountCard();
		}

		public String requestUnregisterFinAccountCard(String number, String date, String type)
		{
			return Marshal.PtrToStringAnsi(S2KiOS.requestUnregisterFinAccountCard(number, date, type));
		}

		public String registerUserMessage(String message)
		{
			return Marshal.PtrToStringAnsi(S2KiOS.registerUserMessage(message));
		}

		public String requestUserMessageList()
		{
			return Marshal.PtrToStringAnsi(S2KiOS.requestUserMessageList());
		}

		public String registerDeviceChange(String userID, String userPW, String authCode)
		{
			return Marshal.PtrToStringAnsi(S2KiOS.registerDeviceChange(userID, userPW, authCode));
		}

		public String makeSignSession()
		{
			return Marshal.PtrToStringAnsi(S2KiOS.makeSignSession());
		}

		public String registerDeviceInfo()
		{
			return Marshal.PtrToStringAnsi(S2KiOS.registerDeviceInfo());
		}

		public String pc_registerDeviceChange(String userID, String userPW, String authCode)
		{
			return Marshal.PtrToStringAnsi(S2KiOS.pc_registerDeviceChange(userID, userPW, authCode));
		}

		public String pc_requestTempPassword(String userID, String authCode, String email)
		{
			return Marshal.PtrToStringAnsi(S2KiOS.pc_requestTempPassword(userID, authCode, email));
		}

		public String pc_registerDeviceAndUserInfo(String userID, String userPW, String authCode, String email, String agree, String pushID)
		{
			return Marshal.PtrToStringAnsi(S2KiOS.pc_registerDeviceAndUserInfo(userID, userPW, authCode, email, agree, pushID));
		}

		public String pc_requestRegisteredList()
		{
			return Marshal.PtrToStringAnsi(S2KiOS.pc_requestRegisteredList());
		}

		public String pc_registerPCState(String targetType, String targetInfo, String state)
		{
			return Marshal.PtrToStringAnsi(S2KiOS.pc_registerPCState(targetType, targetInfo, state));
		}

		public String pc_requestNoticeList()
		{
			return Marshal.PtrToStringAnsi(S2KiOS.pc_requestNoticeList());
		}

		public String pc_requestQNAList()
		{
			return Marshal.PtrToStringAnsi(S2KiOS.pc_requestQNAList());
		}

		public String pc_registerQuestion(String message)
		{
			return Marshal.PtrToStringAnsi(S2KiOS.pc_registerQuestion(message));
		}

		public String pc_requestLatestVersion()
		{
			return Marshal.PtrToStringAnsi(S2KiOS.pc_requestLatestVersion();
		}

		public String pc_requestReleaseDevice()
		{
			return Marshal.PtrToStringAnsi(S2KiOS.pc_requestReleaseDevice());
		}

		public String pc_brokeService(String pushID, String authCode)
		{
			return Marshal.PtrToStringAnsi(S2KiOS.pc_brokeService(pushID, authCode));
		}

		public String readUserInfo()
		{
			return Marshal.PtrToStringAnsi(S2KiOS.readUserInfo());
		}
	}
}
