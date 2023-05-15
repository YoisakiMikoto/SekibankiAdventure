using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailDetect : MonoBehaviour
{
    public LevelFail f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var p=collision.GetComponent<RoleSkill>();
        if (p!=null)
        {
            f.IsFail=true;
        }
    }
}
