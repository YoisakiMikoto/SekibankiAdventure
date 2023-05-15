using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{
    Animator ani;
    public float timer=0;
    public bool tri=false;
    void Start()
    {
        ani=GetComponent<Animator>();
        ani.SetBool("Trigger",false);
    }
    void Update()
    {
        if (tri) timer+=Time.deltaTime;
        if (timer>=0.8f)
        {
            timer=0;
            tri=false;
            ani.SetBool("Trigger",false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.GetContact(0).normal);
        if (collision.GetContact(0).normal.y < 0)
        {
            collision.rigidbody.AddForce(Vector2.up * 5500);
            ani.SetBool("Trigger",true);
            tri=true;
        }
    }
}
