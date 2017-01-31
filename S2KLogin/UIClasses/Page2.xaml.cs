using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace S2KLogin
{
	public partial class Intro2 : ContentPage
	{
		public Intro2 ()
		{
			InitializeComponent ();
		}
		public async void OnPrevious(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Intro1(), false);
		}
		 public async void OnNext2(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Intro3(), false);
		}
	}
}

