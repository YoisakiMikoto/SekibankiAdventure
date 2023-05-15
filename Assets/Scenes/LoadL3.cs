using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadL3 : MonoBehaviour
{
    public void GotoL3()
    {
        var r=FindObjectOfType<LevelRecord>();
        r.level4=true;
        SceneManager.LoadScene("L3");
    }
}
