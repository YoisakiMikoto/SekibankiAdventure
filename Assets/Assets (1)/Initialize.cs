using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initialize : MonoBehaviour
{
    public Transform chain0;
    public Transform chain1;
    public Transform chain2;
    public Transform chain3;
    public Transform chain4;
    public Transform chain5;
    public Transform chain6;
    public Transform chain7;
    public Transform chain8;
    public Transform chain9;
    public Transform chain10;
    public Transform chain11;
    public Transform chain12;
    public Transform chain13;
    public Transform chain14;
    public Transform head;
    public Transform target;


    private void OnEnable()
    {
        chain0.position = target.position;
        chain1.position = target.position;
        chain2.position = target.position;
        chain3.position = target.position;
        chain4.position = target.position;
        chain5.position = target.position;
        chain6.position = target.position;
        chain7.position = target.position;
        chain8.position = target.position;
        chain9.position = target.position;
        chain10.position = target.position;
        chain11.position = target.position;
        chain12.position = target.position;
        chain13.position = target.position;
        chain14.position = target.position;
        head.position = target.position - new Vector3(0, 0, 0.1f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
