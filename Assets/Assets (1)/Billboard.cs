using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    public GameObject text;
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        spriteRenderer.color = Color.white;
        text.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        var IsPlayer = collision.GetComponent<RoleCtrl>();
        if (IsPlayer != null)
        {
            text.SetActive(true);
            spriteRenderer.color = Color.gray;
        }
    }
}
