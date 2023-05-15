using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSuccess : MonoBehaviour
{
    public Chest c;
    public GameObject SuccessButton;
    public GameObject PauseButton;
    public Text stext;
    public Graphic jpg;
    public GameObject Background;
    public float timer=0;
    RoleCtrl roleCtrl;
    RoleSkill roleSkill;
    void Start()
    {
        SuccessButton.SetActive(false);
        stext.CrossFadeAlpha(0f,0f,false);
        jpg.CrossFadeAlpha(0f,0f,false);
        Background.SetActive(false);
        roleCtrl=FindObjectOfType<RoleCtrl>();
        roleSkill=FindObjectOfType<RoleSkill>();
    }
    void Update()
    {
        if (c.LevelClear)
        {
            roleCtrl.Freeze=true;
            PauseButton.SetActive(false);
            timer+=Time.deltaTime;
        }
        if (timer>=1)
        {
            roleCtrl.enabled = false;
            roleSkill.enabled = false;
            Background.SetActive(true);
            stext.CrossFadeAlpha(1f,1f,false);
            jpg.CrossFadeAlpha(1f,1f,false);
        }
        if (timer>=2.5f) SuccessButton.SetActive(true);
    }
}
