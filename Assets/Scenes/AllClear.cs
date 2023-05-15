using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllClear : MonoBehaviour
{
    public Chest c;
    public GameObject SuccessButton;
    public GameObject PauseButton;
    public Text stext;
    public GameObject jpg;
    public GameObject Background;
    public float timer=0;
    void Start()
    {
        SuccessButton.SetActive(false);
        stext.CrossFadeAlpha(0f,0f,false);
        jpg.SetActive(false);
        Background.SetActive(false);
    }
    void Update()
    {
        if (c.LevelClear)
        {
            PauseButton.SetActive(false);
            timer+=Time.deltaTime;
        }
        if (timer>=1)
        {
            Background.SetActive(true);
            stext.CrossFadeAlpha(1f,1f,false);
        }
        if (timer>=4) jpg.SetActive(true);
        if (timer>=5) SuccessButton.SetActive(true);
    }
}
