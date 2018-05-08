using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Zhihu.Core.ViewModels.Base;

namespace Zhihu.Core.ViewModels
{
    class NotificationViewModel : ViewModelBase
    {
        public NotificationViewModel() {

        }

        public override Task InitializeAsync(Object navigationData) {
            return base.InitializeAsync(navigationData);
        }
    }
}
