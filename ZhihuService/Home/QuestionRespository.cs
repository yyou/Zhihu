﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ZhihuService.Home
{
    public class QuestionRepository : Repository<Question>, IQuestionRepository
    {
        public QuestionRepository(HomeDbContext dbContext) 
            : base(dbContext) {

        }
    }
}
