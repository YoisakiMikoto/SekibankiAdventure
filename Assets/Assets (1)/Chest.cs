using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public bool LevelClear=false;
    public RoleSkill p;
    Animator animator;
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool ("IsOpen", false);
        // text.SetActive(false);
    }
    private void OnEnable()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (p.Key>=p.KeyNeed) text.SetActive(false);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        text.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var IsPlayer = collision.GetComponent<RoleCtrl>();
        if (IsPlayer != null && p.Key>=p.KeyNeed)
        {
            // text.SetActive(true);
            animator.SetBool("IsOpen", true);
            LevelClear=true;
        }
        if (IsPlayer!=null && p.Key<p.KeyNeed)
        {
            text.SetActive(true);
        }
    }

}
