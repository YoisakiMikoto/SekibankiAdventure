using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject SelectButton;
    void Start()
    {
        SelectButton.SetActive(false);
    }
    void Update()
    {
        var r=FindObjectOfType<LevelRecord>();
        if (r.Level1) SelectButton.SetActive(true);
    }
}
