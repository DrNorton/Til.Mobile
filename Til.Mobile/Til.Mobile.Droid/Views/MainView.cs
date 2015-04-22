using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace Til.Mobile.Droid.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class MainView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Page_MainView);
        }
    }
}