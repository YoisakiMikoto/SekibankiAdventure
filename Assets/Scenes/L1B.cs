using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1B : MonoBehaviour
{
    public LevelRecord r;
    public GameObject l2b,l3b,l4b,l5b;
    void Start()
    {
        l2b.SetActive(false);
        l3b.SetActive(false);
        l4b.SetActive(false);
        l5b.SetActive(false);
    }
    void Update()
    {
        r=FindObjectOfType<LevelRecord>();
        if (r.level2) l2b.SetActive(true);
        if (r.level3) l3b.SetActive(true);
        if (r.level4) l4b.SetActive(true);
        if (r.level5) l5b.SetActive(true);
    }
}
