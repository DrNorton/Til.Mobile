using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Cirrious.MvvmCross.WindowsPhone.Views;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Til.Mobile.ViewModels;

namespace Til.Mobile.WinPhone.Views
{
    public partial class PostListView : MvxPhonePage
    {
        public PostListView()
        {
            InitializeComponent();
        }

        private void RadDataBoundListBox_OnDataRequested(object sender, EventArgs e)
        {
            (this.DataContext as PostListViewModel).RequestDataCommand.Execute(e);
        }
    }
}