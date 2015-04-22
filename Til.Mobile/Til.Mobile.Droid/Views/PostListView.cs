using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Cirrious.MvvmCross.Binding.Droid.Views;
using Cirrious.MvvmCross.Droid.Views;
using Com.Telerik.Widget.List;

namespace Til.Mobile.Droid.Views
{
    [Activity(Label = "View for List")]
    public class PostListView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            var bindingContext = this.BindingContext;
            SetContentView(Resource.Layout.Page_PostListView);
            RadListView listView = FindViewById<RadListView>(Resource.Id.TheListView);
           
        }
    }
}