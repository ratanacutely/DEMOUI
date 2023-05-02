using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class DialogControl : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;
    [SerializeField]
    private ScreenManagement screenManagement;

    public void SetScore(int score,int maxScore)
    {
        scoreText.text = "SCORE : " + score + "/" + maxScore;
    }
    public void Menu()
    {
        screenManagement.GamePlayClickBack();
        Clear();
    }

    public void Clear()
    {
        scoreText.text = "SCORE : 0/0";
        gameObject.SetActive(false);
    }

    public void PlayNext()
    {
        Clear();
        GameSystem.instance.StartPlayGame("");

    }

    public void Restart()
    {
        Clear();
        GameSystem.instance.StartPlayGame("");
    }
}
