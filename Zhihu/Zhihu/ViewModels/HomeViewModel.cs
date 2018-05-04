using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using Zhihu.Core.ViewModels.Base;
using Zhihu.Core.Services.Navigation;
using System.Threading.Tasks;

namespace Zhihu.Core.ViewModels
{
    public class HomeViewModel : ViewModelBase {

        private ObservableCollection<AnswerDto> _answers;

        public ObservableCollection<AnswerDto> Answers {
            get { return _answers; }
            set {
                _answers = value;
                RaisePropertyChanged(() => Answers);
            }
        }

        public ICommand AnswerDetailCommand { private set; get; }

        public HomeViewModel() {
            AnswerDetailCommand = new Command(async (object answer) => {
                await this.NavigationService.NavigateToAsync<AnswerDetailViewModel>(answer);
            });
        }

        public override async Task InitializeAsync(Object navigationData) {
            this.Answers = await ZhihuServiceClient.Top10Async();
        }
    }
}
