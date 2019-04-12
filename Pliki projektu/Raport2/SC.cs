using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SC : MonoBehaviour
{
    public void LoadLevel ()
    {
        SceneManager.LoadScene("Poziomy");
    }
    public void startlvl1 ()
    {
        SceneManager.LoadScene("poziom1");
    }
    public void exit()
    {
        Application.Quit();
    }
}
