using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadL15In : MonoBehaviour
{
    public void GotoL15In()
    {
        var r = FindObjectOfType<LevelRecord>();
        r.Level1 = true;
        SceneManager.LoadScene("L1.5instructions");
    }
}
