using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowKey : MonoBehaviour
{
    public Text K;
    public RoleSkill p;
    void Update()
    {
        K.text="碎片："+p.Key+"/"+p.KeyNeed;
    }
}
