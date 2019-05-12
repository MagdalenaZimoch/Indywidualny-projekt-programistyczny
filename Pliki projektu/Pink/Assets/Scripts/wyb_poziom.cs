using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wyb_poziom : MonoBehaviour
{
    public void backmenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void exit ()
    {
        Application.Quit();

    }
    public void wybpoz ()
    {
        SceneManager.LoadScene("Poziomy");
    }
}
