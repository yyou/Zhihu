using System;
using System.Collections.Generic;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;

namespace ZhihuService.Home {
    [Produces("application/json")]
    [Route("api/Answer")]
    public class AnswerController : Controller
    {
        private IQuestionService _questionService;

        public AnswerController(IQuestionService questionService) {
            _questionService = questionService;
        }

        // GET: api/Answer
        [HttpGet]
        public List<AnswerDto> Top10() {
            var answers = _questionService.GetTopAnswers(10);
            var answerDtos = new List<AnswerDto>();
            foreach(var answer in answers) {
                answerDtos.Add(Helper.ConvertAnswer(answer));
            }
            return answerDtos;
        }

        [HttpGet("{id}")]
        public AnswerDto Get(Int32 id) {

            var answer = _questionService.Find(id);
            if (answer == null) {
                return null;
            }
            return Helper.ConvertAnswer(answer);
        }
    }

    public class AnswerDto {
        public Int32 Id { get; set; }
        public string Content { get; set; }
        public string QuestionTitle { get; set; }

    }

    public static class Helper {
        public static AnswerDto ConvertAnswer(Answer answer) {
            return new AnswerDto() {
                Id = answer.Id,
                Content = answer.Content,
                QuestionTitle = answer.Question.Title
            };
        }
    }


}
