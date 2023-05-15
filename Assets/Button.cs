using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject ButtonOn;
    public GameObject ButtonOff;
    public GameObject Block;
    public bool Active;
    void Start()
    {
        ButtonOn.SetActive(false);
        ButtonOff.SetActive(true);
        Active=false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("!");
        ButtonOn.SetActive(true);
        ButtonOff.SetActive(false);
        Block.SetActive(false);
        Active=true;
    }
}
