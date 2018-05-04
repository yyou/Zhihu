using System.Threading.Tasks;
using Acr.UserDialogs;

namespace Zhihu.Common.Services {
    public class DialogService : IDialogService {
        public Task ShowAlertAsync(string message, string title, string buttonLabel) {
            return UserDialogs.Instance.AlertAsync(message, title, buttonLabel);
        }
    }
}
