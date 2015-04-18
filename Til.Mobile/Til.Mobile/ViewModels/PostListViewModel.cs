using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;
using Til.Mobile.Api.Facade;
using Til.Mobile.Api.Models;
using Til.Mobile.ViewModels.Base;

namespace Til.Mobile.ViewModels
{
    public class PostListViewModel:LoadingScreen
    {
        private readonly IApiFacade _apiFacade;
        private ObservableCollection<Post> _posts;
        private MvxCommand _requestDataCommand;
        private MvxCommand _refreshCommand;
        private int _count = 20;
        private int _offset = 0;


        public ICommand RefreshCommand
        {
            get
            {
                _refreshCommand = _refreshCommand ?? new MvxCommand(RefreshData);
                return _refreshCommand;
            }
        }

       

        public ICommand RequestDataCommand
        {
            get
            {
                _requestDataCommand = _requestDataCommand ?? new MvxCommand(RequestData);
                return _requestDataCommand;
            }
        }

        private async void RequestData()
        {
            var response = await _apiFacade.GetPosts(_offset, _count);
            foreach (var post in response.Posts)
            {
                Posts.Add(post);
            }
            _offset += _count;
        }

        private void RefreshData()
        {
            _offset = 0;
            Posts=new ObservableCollection<Post>();
        }

        public PostListViewModel(IApiFacade apiFacade)
        {
            _apiFacade = apiFacade;
           _posts=new ObservableCollection<Post>();
        }



        public ObservableCollection<Post> Posts
        {
            get { return _posts; }
            set
            {
                _posts = value;
                base.RaisePropertyChanged(()=>Posts);
            }
        }

     
    }
}
