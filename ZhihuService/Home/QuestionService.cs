using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZhihuService.Home
{
    public class QuestionService : IQuestionService {
        private IQuestionRepository _questionRepository;
        private IAnswerRepository _answerRepository;

        public QuestionService(
            IQuestionRepository questionRepository,
            IAnswerRepository answerRepository) {

            _questionRepository = questionRepository;
            _answerRepository = answerRepository;
        }

        public List<Answer> GetTopAnswers(Int32 topN) {
            if (topN <= 0) {
                return new List<Answer>();
            }
            return _answerRepository.GetAll().Take(topN).ToList();
        }

        public Answer Find(Int32 id) {
            return _answerRepository.Get(id);
        }
    }
}
