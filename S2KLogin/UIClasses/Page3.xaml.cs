using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace S2KLogin
{
	public partial class Intro3 : ContentPage
	{
		public Intro3 ()
		{
			InitializeComponent ();
		}
		public async void OnPrevious2(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Intro2(), false);
		}
		 public async void OnLogin(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Login());
		}
	}
}

