using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quiz
{
    public string Question;
    public List<Answer> Answers = new List<Answer>();

    public Quiz()
    {
        Answers = new List<Answer>();
    }

    public Quiz(string question, List<Answer> answers)
    {
        this.Question = question;
        this.Answers = answers;
    }
}
