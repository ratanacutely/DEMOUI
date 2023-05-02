using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class QuizControl : MonoBehaviour
{
    [SerializeField]
    private Text questionText;
    [SerializeField]
    private AnswerElement[] answerElements;

    public void PlayNext(Quiz quiz)
    {
        questionText.text = quiz.Question;
        for(int i = 0; i < answerElements.Length;i++)
        {
            answerElements[i].SetAnswer(quiz.Answers[i]);
        }
    }
    public void Clear()
    {
        foreach(AnswerElement e in answerElements)
        {
            e.Clear();
        }
    }
}
