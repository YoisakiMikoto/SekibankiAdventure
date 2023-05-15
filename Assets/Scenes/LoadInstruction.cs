using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadInstruction : MonoBehaviour
{
    public void GotoInstruction()
    {
        SceneManager.LoadScene("Instructions");
    }
}
