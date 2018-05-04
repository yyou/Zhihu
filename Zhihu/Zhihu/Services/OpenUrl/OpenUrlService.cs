using System;
using Xamarin.Forms;

namespace Zhihu.Core.Services.OpenUrl
{
    public class OpenUrlService : IOpenUrlService
    {
        public void OpenUrl(string url)
        {
            Device.OpenUri(new Uri(url));
        }
    }
}
