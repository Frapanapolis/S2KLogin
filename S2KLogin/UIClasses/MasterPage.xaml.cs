using System.Collections.Generic;
using Xamarin.Forms;

namespace S2KLogin
{
	public partial class MasterPage : ContentPage
	{
		public ListView ListView { get { return listView; } }

		public MasterPage ()
		{
			InitializeComponent ();

			 


			var masterPageItems = new List<MasterPageItem> ();

			masterPageItems.Add(new MasterPageItem
			{
				Title = "Home",
				IconSource = "ic_home_white_24dp.png",
				TargetType = typeof(Home)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "PC Registration",
				IconSource = "ic_mode_edit_white_24dp.png",
				TargetType = typeof(PCRegistration)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Notice",
				IconSource = "ic_mail_outline_white_24dp.png",
				TargetType = typeof(Notice)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "QNA",
				IconSource = "ic_feedback_white_24dp.png",
				TargetType = typeof(QNA)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "App Settings",
				IconSource = "ic_settings_white_24dp.png",
				TargetType = typeof(AppSettings)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "App Version",
				IconSource = "ic_info_white_24dp.png",
				TargetType = typeof(Version)
			});

			masterPageItems.Add(new MasterPageItem
			{
				Title = "Factory Reset",
				IconSource = "ic_restore_white_24dp.png",
				TargetType = typeof(Reset)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Password Settings",
				IconSource = "ic_security_white_24dp.png",
				TargetType = typeof(PasswordMenu)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Push Settings",
				IconSource = "ic_notifications_white_24dp.png",
				TargetType = typeof(PushSetting)
			});

			listView.ItemsSource = masterPageItems;
		}
	}
}
