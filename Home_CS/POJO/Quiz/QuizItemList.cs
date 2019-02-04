using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Home_CS.POJO.Quiz
{
    class QuizItemList
    {
        private List<QuizItem> quizItems;

        public QuizItemList()
        {
            quizItems = new List<QuizItem>();
        }

        public List<QuizItem> QuizItems
        {
            get { return quizItems; }
            set { quizItems = value; }
        }

        public void AddQuizItem(QuizItem item)
        {
            quizItems.Add(item);
        }
    }
}