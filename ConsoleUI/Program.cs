using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //QuestionTest();

            AnswerTest();

        }

        private static void AnswerTest()
        {
            AnswerManager answerManager = new AnswerManager(new EfAnswerDal());

            var result = answerManager.GetAllByQuestionId(7);

            if (result.Success == true)
            {
                foreach (var answer in result.Data)
                {
                    Console.WriteLine(answer.Content);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            

        }

        private static void QuestionTest()
        {
            QuestionManager questionManager = new QuestionManager(new EfQuestionDal());

            var result = questionManager.GetQuestionDetails();

            if (result.Success ==true)
            {
                foreach (var question in result.Data)
                {
                    Console.WriteLine(question.Title + question.Content);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            
        }
    }
}
