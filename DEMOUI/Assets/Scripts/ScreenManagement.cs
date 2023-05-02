using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManagement : MonoBehaviour
{
    [SerializeField]
    private AudioClip soundClipButton;

    public GameObject screenTitle;
    public GameObject screenCategory;
    public GameObject screenGamePlay;

    [SerializeField]
    GameObject startGameTitle, startButtonPlay;

    private Vector3 startGameTransform, startButtonTransform;

    private void Awake()
    {
        startGameTransform = startGameTitle.transform.position;
        startButtonTransform = startButtonPlay.transform.position;
    }
    public void StartClick()
    {
        LeanTween.scale(startButtonPlay, new Vector3(1.4f, 1.4f, 1.2f), 1f)
            .setEase(LeanTweenType.easeInBack)
            .setOnComplete(OnScaleComplete);

    }

    private void OnScaleComplete()
    {
        startButtonPlay.transform.localScale = new Vector3(1, 1, 1);


        screenTitle.SetActive(false);
        screenCategory.SetActive(true);
        ResetPositionObjectsTitle();
        AudioManager.instance.Play(soundClipButton);
    }

    public void CategoryBackClick()
    {
        screenCategory.SetActive(false);
        screenTitle.SetActive(true);

        AudioManager.instance.Play(soundClipButton);
    }

    public void CategoryClick(string category)
    {
        Debug.Log("category => " + category);

        screenCategory.SetActive(false);
        screenGamePlay.SetActive(true);
        AudioManager.instance.Play(soundClipButton);

        GameSystem.instance.StartPlayGame(category);
    }

    public void GamePlayClickBack()
    {
        screenGamePlay.SetActive(false);
        screenCategory.SetActive(true);
        AudioManager.instance.Play(soundClipButton);
    }

    private void ResetPositionObjectsTitle()
    {
        startGameTitle.transform.position = startGameTransform;
        startButtonPlay.transform.position = startButtonTransform;
    }
}
