using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class L1Restart : MonoBehaviour
{
    public void RestartL1()
    {
        Time.timeScale=1;
        SceneManager.LoadScene("L1");
    }
}
