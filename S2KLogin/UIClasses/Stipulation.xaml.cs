using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace S2KLogin
{
	public partial class Stipulation : ContentPage
	{
		public Stipulation ()
		{
			InitializeComponent ();
			 
		}
		public async void OnCancle(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Login(), false);
		}
		public async void OnAgree(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Login(), false);
		}
		  
	}
}

