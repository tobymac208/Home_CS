using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_CS.POJO.Quiz
{
    class Quiz {
        private QuizItemList quizItems;
        private int numCorrect;
        private int numIncorrect;
        private int currentQuestion;
        private int currentAnswer;

        public Quiz(QuizItemList quizItems)
        {
            this.quizItems = quizItems;
            this.numIncorrect = 0;
            this.numCorrect = 0;
            this.currentQuestion = 0;
            this.currentAnswer = 0;
        }

        public int NumberCorrect
        {
            get { return numCorrect; }
            set { numCorrect = value; }
        }

        public int NumberIncorrect
        {
            get { return numIncorrect; }
            set { numIncorrect = value; }
        }

        public void AddCorrect()
        {
            numCorrect++;
        }

        public void AddIncorrect()
        {
            numIncorrect++;
        }

        /** Get the current question */
        public String GetQuestion()
        {
            if (currentQuestion >= quizItems.QuizItems.Count)
            {
                return "no more questions.";
            }
            string question = quizItems.QuizItems.ElementAt(currentQuestion).Question;
            currentQuestion++;
            // return question;
            return "";
        }

        /** Get the current answer. */
        public String GetAnswer()
        {
            if (currentAnswer >= quizItems.QuizItems.Count)
            {
                return "no more answers.";
            }
            string answer = quizItems.QuizItems.ElementAt(currentAnswer).Answer;
            currentAnswer++;
            // return answer;
            return "";
        }
    }
}
