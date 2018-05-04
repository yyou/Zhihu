using System;
using System.Collections.Generic;
using System.Text;

namespace Zhihu.Common.Services
{
    public interface IDependencyService {
        T Get<T>() where T : class;
    }
}
