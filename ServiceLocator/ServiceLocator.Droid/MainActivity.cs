using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ServiceLocator.Droid
{
	[Activity (Label = "ServiceLocator", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

            Locator.Instance.Add<ITextToSpeech, TextToSpeechService>();

            global::Xamarin.Forms.Forms.Init (this, bundle);
			LoadApplication (new ServiceLocator.App ());
		}
	}
}

