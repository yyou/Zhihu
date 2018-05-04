using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZhihuService.Home
{
    public static class HomeDbInitializer
    {
        public static void Initialize(HomeDbContext dbContext) {
            dbContext.Database.EnsureCreated();

            if (dbContext.Questions.Any()) {
                return;
            }

            var questions = new Question[] {
                new Question() {
                    Title = "JavaScript 入门哪本书最好？",
                    Content = "想学javascript， 不知道哪本书比较好，谢谢。",
                    Answers = new List<Answer>() {
                        new Answer() {
                            Content = "入门可以看《javascript高级程序设计》与《javascript dom 编程艺术》尤其是后者，真是好书。我以前看了许多视频，翻那本很厚的指南与高程，最后还是靠《javascript dom 编程艺术》激发我学习兴趣入门。",
                        },
                        new Answer() {
                            Content = " 我觉得悟透JavaScript和javascript王者归来这两本书都是作者装B的典范" + "\r\n" +
                                "王者归来里面大段大段的fp内容完全照抄国外某些讲fp的书一个字都不改。。以至于看起来有“哦，这货是在讲js么”的错觉，全书为了骗钱到处录代码。。一个dws函数全书估计印刷了100+次！太坑人了"
                        },
                        new Answer() {
                            Content = "悟透JavaScript这本书没细看，作者试图用一种类似宗教和你永远看不太懂的语言组织一些其实非常简单的东西，作者可能认为这才达到了深入浅出的目的，但是很明显，他失败了。。"
                        }
                    }
                },
                new Question() {
                    Title = "如何看待 2018 年 3 月 28 日 B 站赴美上市，拟融资 4.83 亿美元？",
                    Content = "2017年12月21日，《财经》从多个信源获悉，视频弹幕网站哔哩哔哩（Bilibili，简称B站）目前已经进入上市前静默期，并最快将于2018年第一季度在美国上市。" + "\r\n" + 
"据《财经》记者了解，B站的IPO辅导从2016年开始启动。记者向B站方面求证IPO的最新进展，对方表示不予置评 ，并称目前尚未向外界披露过相关信息。" + "\r\n" +
"2017年10月，彭博社曾报道，B站将在美国进行IPO，最少筹资2亿美元，上市后，B站市值将超过10亿美元。对此，其中一位消息人士向《财经》记者透露，目前B站估值不止10亿美元，而是在30-35亿美元。",
                    Answers = new List<Answer>() {
                        new Answer() {
                            Content = "B站运作上市这件事情其实已经蛮久，17年下半年就有消息说内部在运作；"
                        },
                        new Answer() {
                            Content = "估值的问题，之前曝光新闻国内A股公司掌趣参与的那轮是17亿RMB"
                        }
                    }
                }
            };

            foreach(var question in questions) {
                dbContext.Questions.Add(question);
            }

            dbContext.SaveChanges();            
        }
    }
}
