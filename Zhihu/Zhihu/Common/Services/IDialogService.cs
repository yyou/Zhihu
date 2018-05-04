using System.Threading.Tasks;

namespace Zhihu.Common.Services {
    public interface IDialogService {
        Task ShowAlertAsync(string message, string title, string buttonLabel);
    }
}