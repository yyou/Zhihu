using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Zhihu.Core.ViewModels.Base;

namespace Zhihu.Core.ViewModels
{
    public class AnswerDetailViewModel : ViewModelBase
    {
        private string _questionTitle;
        public string QuestionTitle {
            get => _questionTitle;
            set {
                _questionTitle = value;
                RaisePropertyChanged(() => QuestionTitle);
            }
        }

        private string _content;
        public string Content {
            get => _content;
            set {
                _content = value;
                RaisePropertyChanged(() => Content);
            }
        }
        
        public AnswerDetailViewModel() {

        }

        public override async Task InitializeAsync(Object navigationData) {
            var answer = (AnswerDto)navigationData;
            var answerDto = await this.ZhihuServiceClient.GetAsync(answer.Id);
            this.QuestionTitle = answerDto.QuestionTitle;
            this.Content = answerDto.Content;
        }
    }
}
