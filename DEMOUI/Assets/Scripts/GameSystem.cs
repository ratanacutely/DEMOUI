using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour
{
    [HideInInspector]
    public static GameSystem instance = null;
    [HideInInspector]
    public string category;

    //gameplay
    public GamePlay gamePlay;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void StartPlayGame(string category)
    {
        this.category = category;
        gamePlay.StartPlayGame();
    }
}
