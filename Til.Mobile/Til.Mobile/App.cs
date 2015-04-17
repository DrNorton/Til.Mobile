using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.ViewModels;
using Til.Mobile.Api;
using Til.Mobile.Api.Executer;
using Til.Mobile.Api.Facade;
using Til.Mobile.Settings;
using Xamarin.Forms;

namespace Til.Mobile
{
    public class App : MvxApplication
	{
		public App ()
		{
			// The root page of your application
			
		}

        public override void Initialize()
        {
            //CreatableTypes()
            //    .EndingWith("Service")
            //    .AsInterfaces()
            //    .RegisterAsLazySingleton();

            RegisterAppStart<ViewModels.MainViewModel>();
            // _apiExecuter = new ApiExecuter("http://hskingapi.azurewebsites.net/api");
            Mvx.RegisterType<IApiSettings, ApiSettings>();
            Mvx.RegisterType<IApiExecuter, ApiExecuter>();
            Mvx.RegisterType<IApiFacade, ApiFacade>();
            //Mvx.RegisterType<IRequestExecuterService, RequestExecuterService>();
            //Mvx.ConstructAndRegisterSingleton<IApiManager, ApiManager>();
        }
	}
}
