using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadStart : MonoBehaviour
{
    public void LoadStartScene()
    {
        SceneManager.LoadScene("StartScreen");
    }
}
