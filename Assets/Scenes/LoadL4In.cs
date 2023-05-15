using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadL4In : MonoBehaviour
{
    public void GotoL4Instructions()
    {
        SceneManager.LoadScene("L4Instructions");
    }
}
