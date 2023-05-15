using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class L15Restart : MonoBehaviour
{
    public void RestartL15()
    {
        Time.timeScale=1;
        SceneManager.LoadScene("L1.5");
    }
}
