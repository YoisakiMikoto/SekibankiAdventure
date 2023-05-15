using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMenu : MonoBehaviour
{
    public void GotoMenu()
    {
        Time.timeScale=1;
        SceneManager.LoadScene("Menu");
    }
}
