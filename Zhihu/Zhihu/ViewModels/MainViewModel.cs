using Zhihu.Core.Models.Navigation;
using Zhihu.Core.ViewModels.Base;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Zhihu.Core.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel() {

        }

        public override Task InitializeAsync(object navigationData)
        {
            IsBusy = true;

            if (navigationData is TabParameter) {
                // Change selected application tab
                var tabIndex = ((TabParameter)navigationData).TabIndex;
                MessagingCenter.Send(this, MessageKeys.ChangeTab, tabIndex);
            }
            return base.InitializeAsync(navigationData);
        }
    }
}