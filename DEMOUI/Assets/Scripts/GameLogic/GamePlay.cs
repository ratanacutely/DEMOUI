using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    [SerializeField]
    private QuizControl quizControl;

    [SerializeField]
    private DialogControl winDialog;
    [SerializeField]
    private DialogControl lostDialog;

    private List<Quiz> quizs = new List<Quiz>();
    private void Awake()
    {
        //quizs = GenerateQuiz.GenerateQuizs();
    }

    private void Start()
    {
        //PlayNext();
    }

    public void StartPlayGame()
    {
        quizs = GenerateQuiz.GenerateQuizs();
        PlayNext();
    }

    public void PlayNext()
    {
        if(quizs.Count == 0)
        {
            winDialog.gameObject.SetActive(true);
            lostDialog.SetScore(10, 10);
        }
        else
        {
            Quiz quiz = quizs[0];
            quizControl.PlayNext(quiz);
            quizs.RemoveAt(0);
        }
    }

    public void LostGame()
    {
        lostDialog.gameObject.SetActive(true);
        lostDialog.SetScore(10 - quizs.Count, 10);
    }
}
