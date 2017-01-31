using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace S2KLogin
{
	public partial class Password : ContentPage
	{
		 

		public Password()
		{
			InitializeComponent();
			PWEntry.TextChanged += (sender, args) =>
			{
				String text = PWEntry.Text;
				if (text.Length > 3)
				{
					#if __ANDROID__
      					DisplayAlert("Message 1", text, "OK");
					#else
      					DisplayAlert("Password", text, "OK", "Cancle");
					#endif
				}
			};
		}
		public void OnClick1(object sender, EventArgs args)
		{
			PWEntry.Text += "1";
		}
		 public void OnClick2(object sender, EventArgs args)
		{
			PWEntry.Text += "2";
		}
		public void OnClick3(object sender, EventArgs args)
		{
			PWEntry.Text += "3";
		}
		public void OnClick4(object sender, EventArgs args)
		{
			PWEntry.Text += "4";
		}
		public void OnClick5(object sender, EventArgs args)
		{
			PWEntry.Text += "5";
		}
		public void OnClick6(object sender, EventArgs args)
		{
			PWEntry.Text += "6";
		}
		public void OnClick7(object sender, EventArgs args)
		{
			PWEntry.Text += "7";
		}
		public void OnClick8(object sender, EventArgs args)
		{
			PWEntry.Text += "8";
		}
		public void OnClick9(object sender, EventArgs args)
		{
			PWEntry.Text += "9";
		}
		public void OnClick0(object sender, EventArgs args)
		{
			PWEntry.Text += "0";
		}
		public void OnClickX(object sender, EventArgs args)
		{
			String val = PWEntry.Text;
			if (val.Length > 0)
			{
				val = val.Remove(val.Length - 1);
				PWEntry.Text = val;
			}

		}
	}
}

