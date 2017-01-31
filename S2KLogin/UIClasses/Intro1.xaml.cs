using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace S2KLogin
{
	public partial class Intro1 : ContentPage
	{
		public Intro1 ()
		{
			InitializeComponent ();
		}

		public async void OnLogin(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Login());
		}

		public async void OnNext1(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Intro2(), false);
		}

	}
}

