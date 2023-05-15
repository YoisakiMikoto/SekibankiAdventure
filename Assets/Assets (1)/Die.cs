using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    LevelFail fail;
    public GameObject die;
    RoleCtrl roleCtrl;
    RoleSkill roleSkill;
    public GameObject body;
    public GameObject head;
    public GameObject chain;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        die.SetActive(false);
        fail=FindObjectOfType<LevelFail>();
        animator = die.GetComponent<Animator>();
        animator.SetBool("IsDead", false);
        roleCtrl = GetComponent<RoleCtrl>();
        roleSkill = GetComponent<RoleSkill>();
        roleCtrl.enabled = true;
        roleSkill.enabled = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (fail.IsFail)
        {
            die.SetActive(true);
            animator.SetBool("IsDead", true);
            roleCtrl.enabled = false;
            roleSkill.enabled = false;
            head.SetActive(false);
            body.SetActive(false);
            chain.SetActive(false);
        }
    }
}
