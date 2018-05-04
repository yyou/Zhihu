using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZhihuService.Home
{
    public class Question : Entity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string AskedBy { get; set; }

        public ICollection<Answer> Answers { get; set; }
    }
}
