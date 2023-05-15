using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetMove : MonoBehaviour
{
    public SkillSaver S;
    public GameObject v;
    public Graphic vv;
    public GameObject Hint;
    void Start()
    {
        Hint.SetActive(false);
        vv.CrossFadeAlpha(0f,0f,false);
        v.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Hint.SetActive(true);
        vv.CrossFadeAlpha(1f,0f,true);
        v.SetActive(true);
        S.canHeadMove=true;
        gameObject.SetActive(false);
        Time.timeScale=0;
    }
}
