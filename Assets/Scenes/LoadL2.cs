using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadL2 : MonoBehaviour
{
    public void GotoL2()
    {
        var r=FindObjectOfType<LevelRecord>();
        r.level3=true;
        SceneManager.LoadScene("L2");
    }
}
