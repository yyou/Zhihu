using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Zhihu.Core.ViewModels.Base;

namespace Zhihu.Core.ViewModels
{
    public class IdeasViewModel : ViewModelBase
    {
        public IdeasViewModel() {

        }

        public override Task InitializeAsync(Object navigationData) {
            return base.InitializeAsync(navigationData);
        }
    }
}
