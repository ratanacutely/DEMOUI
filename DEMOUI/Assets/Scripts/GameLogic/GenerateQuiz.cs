using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateQuiz
{
    public static List<Quiz> GenerateQuizs()
    {
        List<Quiz> quizs = new List<Quiz>();
        for(int i = 0; i < 10; i++)
        {
            Quiz temp = GetQuiz();
            quizs.Add(temp);
        }
        return quizs;
    }


    private static Quiz GetQuiz()
    {
        int leftNum = Random.Range(1, 9);
        int righNum = Random.Range(1, 9);
        Quiz quiz = new Quiz();
        quiz.Question = leftNum + " + " + righNum + " ?";
        quiz.Answers = GetAnswers(leftNum + righNum);

        return quiz;
    }

    private static List<Answer> GetAnswers(int number)
    {
        List<Answer> ansers = new List<Answer>();
        int index = new System.Random().Next(1, 4);
        List<int> numbers = GetNumbers(number);
        for(int i = 0; i < 4; i++)
        {
            ansers.Add(new Answer(numbers[Random.Range(0,numbers.Count)].ToString(), false));
        }
        ansers[index].answer = number.ToString();
        ansers[index].isCorrect = true;
        return ansers;
    }

    private static List<int> GetNumbers(int number)
    {
        List<int> numbers = new List<int>();
        for(int i = 1; i <= 9; i++)
        {
            if (i != number)
                numbers.Add(i);
        }
        return numbers;
    }
}
