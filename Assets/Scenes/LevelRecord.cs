using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelRecord : MonoBehaviour
{
    public bool Level1,level2,level3,level4,level5;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
