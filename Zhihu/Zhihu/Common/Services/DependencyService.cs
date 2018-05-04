using System;
using System.Collections.Generic;
using System.Text;

namespace Zhihu.Common.Services
{
    public class DependencyService : IDependencyService {
        public T Get<T>() where T : class {
            return Xamarin.Forms.DependencyService.Get<T>();
        }
    }
}
