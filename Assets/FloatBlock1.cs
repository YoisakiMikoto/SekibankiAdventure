using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatBlock1 : MonoBehaviour
{
    public RoleCtrl p;
    public float speed=1.5f;
    public float stoptime=0;
    public bool move=true;
    void Update()
    {
        if (transform.position.x>=5.5f && speed>0)
        move=false;
        if (!move)
        stoptime+=Time.deltaTime;
        if (transform.position.x>=5.5f && !move && stoptime>=0.7f)
        {
            speed=-1.5f;
            stoptime=0;
            move=true;
        }
        if (move)
        transform.position+=new Vector3(speed*Time.deltaTime,0,0);
        if (transform.position.x<=-7.5f && speed<0)
        move=false;
        if (transform.position.x<=-7.5f && !move && stoptime>=0.7f)
        {
            speed=1.5f;
            stoptime=0;
            move=true;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        var play=collision.GetComponent<RoleSkill>();
        if (play!=null)
        {
            Debug.Log("st");
            float h = Input.GetAxis("Horizontal");
            collision.gameObject.transform.Translate(new Vector2(speed+p.speed*h,0)*Time.deltaTime);
        }
    }
}
