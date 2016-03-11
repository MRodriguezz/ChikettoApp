using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Android.Runtime;
using Android.Views;
using Android.Views.InputMethods;

namespace SplashAndroide
{
	[Activity (Label = "LoginScreen")]			
	public class LoginScreen : Activity
	{
		LinearLayout mLinearLayout;
		Button mButton;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from  the "main", layout resource 
            SetContentView (Resource.Layout.Login);

			mLinearLayout = FindViewById<LinearLayout> (Resource.Id.mainLogin);
			mButton = FindViewById<Button> (Resource.Id.btnLogin);

			mButton.Click += mButton_Click;
		}
		void mButton_Click (object sender, EventArgs e)
		{
			Intent intent = new Intent (this, typeof(Category));
			this.StartActivity (intent);
			this.OverridePendingTransition(Resource.Animation.slide_in_top, Resource.Animation.slide_out_bottom);
		}
		void mLinearLayout_Click(object sender, EventArgs e)
		{
			InputMethodManager inputManager = (InputMethodManager)this.GetSystemService (Activity.InputMethodService);
			inputManager.HideSoftInputFromWindow (this.CurrentFocus.WindowToken, HideSoftInputFlags.None);
		}
    }
}

