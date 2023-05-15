using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class L2Restart : MonoBehaviour
{
    public void RestartL2()
    {
        Time.timeScale=1;
        SceneManager.LoadScene("L2");
    }
}
