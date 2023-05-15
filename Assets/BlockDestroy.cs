using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDestroy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var b=collision.GetComponent<Bullet>();
        if (b!=null)
        {
            Destroy(gameObject);
        }
    }
}
