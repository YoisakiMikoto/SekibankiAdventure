using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadL4 : MonoBehaviour
{
    public void GotoL4()
    {
        var r=FindObjectOfType<LevelRecord>();
        r.level5=true;
        SceneManager.LoadScene("L4");
    }
}
