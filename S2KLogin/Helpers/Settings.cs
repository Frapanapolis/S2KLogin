// Helpers/Settings.cs
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace S2KLogin.Helpers
{
  /// <summary>
  /// This is the Settings static class that can be used in your Core solution or in any
  /// of your client applications. All settings are laid out the same exact way with getters
  /// and setters. 
  /// </summary>
  public static class Settings
  {
    private static ISettings AppSettings
    {
      get
      {
        return CrossSettings.Current;
      }
    }

    #region Setting Constants

    private const string SettingsKey = "settings_key";
    private static readonly string SettingsDefault = string.Empty;

    #endregion


    public static string GeneralSettings
    {
      get
      {
        return AppSettings.GetValueOrDefault<string>(SettingsKey, SettingsDefault);
      }
      set
      {
        AppSettings.AddOrUpdateValue<string>(SettingsKey, value);
      }
    }




		#region Setting Constants

		private const string device_id = "device_id";
		private static readonly string device_id_default = string.Empty;

		#endregion


		public static string deviceid
		{
			get
			{ return AppSettings.GetValueOrDefault<string>(device_id, device_id_default); }
			set
			{ AppSettings.AddOrUpdateValue<string>(device_id, value); }
		}


		#region Setting Constants

		private const string encData = "DATA";
		private static readonly string encData_default = string.Empty;

		#endregion


		public static string Data
		{
			get
			{ return AppSettings.GetValueOrDefault<string>(encData, encData_default); }
			set
			{ AppSettings.AddOrUpdateValue<string>(encData, value); }
		}

		#region Setting Constants

		private const string VibSettings = "VIBRATION";
		private static readonly string Vib_default = string.Empty;

		#endregion


		public static string Vibration
		{
			get
			{ return AppSettings.GetValueOrDefault<string>(VibSettings, Vib_default); }
			set
			{ AppSettings.AddOrUpdateValue<string>(VibSettings, value); }
		}

		#region Setting Constants

		private const string SoundSettings = "Sound";
		private static readonly string Sound_default = string.Empty;

		#endregion


		public static string Sound
		{
			get
			{ return AppSettings.GetValueOrDefault<string>(SoundSettings, Sound_default); }
			set
			{ AppSettings.AddOrUpdateValue<string>(SoundSettings, value); }
		}

  }
}