using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Zhihu.Core.Services.Navigation;
using Zhihu.Core.Services.Settings;
using Zhihu.Core.ViewModels.Base;
using Zhihu.Core.Views;

namespace Zhihu
{
	public partial class App : Application
	{
        ISettingsService _settingsService;

        public App ()
		{
			InitializeComponent();

            InitApp();
            //MainPage = new MainView_();
		}

        private void InitApp() {
            _settingsService = ViewModelLocator.Resolve<ISettingsService>();
            if (!_settingsService.UseMocks)
                ViewModelLocator.UpdateDependencies(_settingsService.UseMocks);
        }

        private Task InitNavigation() {
            var navigationService = ViewModelLocator.Resolve<INavigationService>();
            return navigationService.InitializeAsync();
        }

        protected override async void OnStart ()
		{
            if (Device.RuntimePlatform != Device.UWP) {
                await InitNavigation();
            }
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
