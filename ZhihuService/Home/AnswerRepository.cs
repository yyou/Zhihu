using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ZhihuService.Home
{
    public class AnswerRepository : Repository<Answer>, IAnswerRepository
    {
        private HomeDbContext _homeDbContext;

        public AnswerRepository(HomeDbContext dbContext)
            : base(dbContext) {

            _homeDbContext = dbContext;
        }

        public override List<Answer> GetAll() {
            var answers = _homeDbContext.Answers.Include(answer => answer.Question);
            return answers.ToList();
        }

        public override Answer Get(Int32 id) {
            var answer = _homeDbContext.Answers
                .Include(a => a.Question)
                .SingleOrDefault(a => a.Id == id);
            return answer;
        }
    }
}
