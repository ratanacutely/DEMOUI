using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButtonAnimation : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.5f;
    [SerializeField]
    private float yPos = 533f;
    private void Awake()
    {
        Debug.Log("Name : " + gameObject.name + " => " + gameObject.transform.position.y);

    }

    private void OnEnable()
    {
        float y = yPos;
        Vector3 v3 = new Vector3(transform.position.x, y, transform.position.z);
        LeanTween.move(gameObject, v3, speed).setEase(LeanTweenType.easeOutElastic);
    }

    private void Start()
    {

    }
}
