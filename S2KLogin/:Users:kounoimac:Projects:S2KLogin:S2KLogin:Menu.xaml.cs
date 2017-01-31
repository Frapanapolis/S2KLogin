using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace S2KLogin
{
	public partial class Menu : ContentPage
	{
		public Menu ()
		{
			InitializeComponent ();
		}
		 public async void OnLogin(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Password(), false);
		}
	}
}

