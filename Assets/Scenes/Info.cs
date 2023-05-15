using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info : MonoBehaviour
{
    public GameObject InfoUI;
    public GameObject PauseMenu;
    public void ShowInfo()
    {
        PauseMenu.SetActive(false);
        InfoUI.SetActive(true);
    }
    public void ExitInfo()
    {
        PauseMenu.SetActive(true);
        InfoUI.SetActive(false);
    }
}
