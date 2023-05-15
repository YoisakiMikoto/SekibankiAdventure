using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class L4Restart : MonoBehaviour
{
    public void RestartL4()
    {
        Time.timeScale=1;
        SceneManager.LoadScene("L4");
    }
}
