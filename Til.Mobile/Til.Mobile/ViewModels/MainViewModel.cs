using System.Diagnostics;
using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;
using Hsking.Mobile.ViewModels;
using Til.Mobile.Api;
using Til.Mobile.ViewModels.Base;


namespace Til.Mobile.ViewModels
{
    public class MainViewModel : LoadingScreen
    {
        private readonly IApiSettings _apiSettings;
        private MvxCommand _navigateToStartCommand;
        private MvxCommand _navigateToListCommand;

        public ICommand NavigateToStartCommand
        {
            get
            {
                _navigateToStartCommand = _navigateToStartCommand ?? new MvxCommand(NavigateToStart);
                return _navigateToStartCommand;
            }
        }

        public ICommand NavigateToListCommand
        {
            get
            {
                _navigateToListCommand = _navigateToListCommand ?? new MvxCommand(NavigateToList);
                return _navigateToListCommand;
            }
        }

        private void NavigateToList()
        {
            ShowViewModel<PostListViewModel>();
        }

        public MainViewModel(IApiSettings apiSettings)
        {
            _apiSettings = apiSettings;
           
        }

        private void NavigateToStart()
        {
            ShowViewModel<StartViewModel>();
        }
    }
}
