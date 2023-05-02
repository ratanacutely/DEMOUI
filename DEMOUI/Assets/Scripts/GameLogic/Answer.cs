using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answer
{
    public string answer;
    public bool isCorrect;

    public Answer()
    {

    }

    public Answer(string answer,bool isCorrect)
    {
        this.answer = answer;
        this.isCorrect = isCorrect;
    }
}
