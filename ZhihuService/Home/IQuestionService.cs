using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZhihuService.Home
{
    public interface IQuestionService
    {
        List<Answer> GetTopAnswers(Int32 topN);
        Answer Find(Int32 id);
    }
}
