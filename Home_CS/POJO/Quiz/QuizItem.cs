using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_CS.POJO.Quiz
{
    class QuizItem
    {
        private String question;
        private String answer;

        public QuizItem(String question, String answer)
        {
            this.question = question;
            this.answer = answer;
        }

        /** Question getter */
        public string Question
        {
            get { return question; }
        }

        /** Answer getter */
        public string Answer
        {
            get { return answer; }
        }
    }
}
