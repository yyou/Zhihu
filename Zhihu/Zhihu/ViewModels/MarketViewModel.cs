using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Zhihu.Core.ViewModels.Base;

namespace Zhihu.Core.ViewModels
{
    class MarketViewModel : ViewModelBase
    {
        public MarketViewModel() {

        }

        public override Task InitializeAsync(Object navigationData) {
            return base.InitializeAsync(navigationData);
        }
    }
}
