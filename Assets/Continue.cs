using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Continue : MonoBehaviour
{
    public GameObject h;
    public GameObject v;
    public void ContinueGame()
    {
        v.SetActive(false);
        h.SetActive(false);
        Time.timeScale=1;
    }
}
