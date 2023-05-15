using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadL3In : MonoBehaviour
{
    public void GotoL3Instructions()
    {
        SceneManager.LoadScene("L3Instructions");
    }
}
