using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelFail : MonoBehaviour
{
    public bool IsFail=false;
    public GameObject PauseButton;
    public GameObject RestartButton;
    public Text Ftext;
    public Graphic jpg;
    public GameObject Back;
    public float timer=0;
    void Start()
    {
        RestartButton.SetActive(false);
        Ftext.CrossFadeAlpha(0f,0f,false);
        jpg.CrossFadeAlpha(0f,0f,false);
        Back.SetActive(false);
    }
    void Update()
    {
        if (IsFail)
        {
            PauseButton.SetActive(false);
            timer+=Time.deltaTime;
        }
        if (timer>=1)
        {
            Back.SetActive(true);
            Ftext.CrossFadeAlpha(1f,1f,false);
            jpg.CrossFadeAlpha(1f,1f,false);
        }
        if (timer>=2.5f) RestartButton.SetActive(true);
    }
}
