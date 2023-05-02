using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class AnswerElement : MonoBehaviour
{
    [SerializeField]
    private Text answerText;
    [HideInInspector]
    public bool IsCorrect = false;
    [SerializeField]
    GamePlay gamePlay;

    //change image ui
    [SerializeField]
    private Sprite originalSprite;
    [SerializeField]
    private Sprite redSprite;
    [SerializeField]
    private Sprite blueSprite;

    public void SetAnswer(Answer answer)
    {
        answerText.text = answer.answer;
        this.IsCorrect = answer.isCorrect;
    }

    public void Clear()
    {
        answerText.text = "";
        this.IsCorrect = false;
        GetComponent<Image>().sprite = originalSprite;
    }

    public void AnswerClick()
    {
        Debug.Log("answer iscorrect =>  " + IsCorrect);
        if (IsCorrect)
        {
            StartCoroutine(WaitPlayNext(0.5f));
        }
        else
        {
            StartCoroutine(WaitShowLostGame(0.5f));
        }
    }
    private IEnumerator WaitPlayNext(float wait)
    {
        GetComponent<Image>().sprite = blueSprite;
        yield return new WaitForSeconds(wait);
        Clear();
        gamePlay.PlayNext();
    }
    private IEnumerator WaitShowLostGame(float wait)
    {
        GetComponent<Image>().sprite = redSprite;
        yield return new WaitForSeconds(wait);
        Clear();
        gamePlay.LostGame();
    }
}
