using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class L3Restart : MonoBehaviour
{
    public void RestartL3()
    {
        Time.timeScale=1;
        SceneManager.LoadScene("L3");
    }
}
