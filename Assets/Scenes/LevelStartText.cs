using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelStartText : MonoBehaviour
{
    public RoleCtrl p;
    public Text LevelText;
    public Text KeyText;
    public Graphic Black;
    public GameObject BB;
    bool LS=false,KS=false,Fade=false,BF=false;
    public float timer;
    bool set;
    void Start()
    {
        p.Freeze=true;
        set=false;
        timer=0;
        LevelText.CrossFadeAlpha(0f,0f,false);
        KeyText.CrossFadeAlpha(0f,0f,false);
    }
    void Update()
    {
        timer+=Time.deltaTime;
        if (timer>=0 && !LS)
        {
            LS=true;
            LevelText.CrossFadeAlpha(1f,1f,false);
        }
        if (timer>=1.5f && !KS)
        {
            KS=true;
            KeyText.CrossFadeAlpha(1f,1f,false);
        }
        if (timer>=3 && !BF)
        {
            BF=true;
            Black.CrossFadeAlpha(0f,1f,false);
        }
        if (timer>=3 && !Fade)
        {
            Fade=true;
            LevelText.CrossFadeAlpha(0f,0.5f,false);
            KeyText.CrossFadeAlpha(0f,0.5f,false);
        }
        if (timer>=4)
        {
            if (!set) p.Freeze=false;
            set=true;
            BB.SetActive(false);
        }
    }
}
