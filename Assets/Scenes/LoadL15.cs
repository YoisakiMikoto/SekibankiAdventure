using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadL15 : MonoBehaviour
{
    public void GotoL15()
    {
        var r=FindObjectOfType<LevelRecord>();
        r.level2=true;
        SceneManager.LoadScene("L1.5");
    }
}
