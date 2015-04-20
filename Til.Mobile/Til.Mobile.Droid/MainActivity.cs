using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace Til.Mobile.Droid
{
   [Activity(Label = "Tip", MainLauncher = true)]
    public class MainActivity : MvxActivity
    {

        public MainActivity()
        {
            
        }
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
        }
    }
}

