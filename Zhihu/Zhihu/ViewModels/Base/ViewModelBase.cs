using System.Threading.Tasks;

using Zhihu.Core.Services.Dialog;
using Zhihu.Core.Services.Navigation;
using Zhihu.Core.Services.Settings;

namespace Zhihu.Core.ViewModels.Base {
    public abstract class ViewModelBase : ExtendedBindableObject
    {
        protected readonly IDialogService DialogService;
        protected readonly INavigationService NavigationService;
        protected readonly IZhihuServiceClient ZhihuServiceClient;

        private bool _isBusy;

        public bool IsBusy
        {
            get
            {
                return _isBusy;
            }

            set
            {
                _isBusy = value;
                RaisePropertyChanged(() => IsBusy);
            }
        }

        public ViewModelBase()
        {
            DialogService = ViewModelLocator.Resolve<IDialogService>();
            NavigationService = ViewModelLocator.Resolve<INavigationService>();
            ZhihuServiceClient = ViewModelLocator.Resolve<IZhihuServiceClient>();
            GlobalSetting.Instance.BaseEndpoint = ViewModelLocator.Resolve<ISettingsService>().UrlBase;
        }

        public virtual Task InitializeAsync(object navigationData)
        {
            return Task.FromResult(false);
        }
    }
}