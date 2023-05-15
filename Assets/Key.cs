using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public RoleSkill p;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var role=collision.GetComponent<RoleCtrl>();
        if (role!=null)
        {
            Destroy(gameObject);
            p.getkey();
        }
    }
}
