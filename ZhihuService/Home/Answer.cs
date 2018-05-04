using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Domain.Entities;

namespace ZhihuService.Home
{
    public class Answer : Entity
    {
        public string Content { get; set; }
        public string AnsweredBy { get; set; }

        public Question Question { get; set; }
    }
}
