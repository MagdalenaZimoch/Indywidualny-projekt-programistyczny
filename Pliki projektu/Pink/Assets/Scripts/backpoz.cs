using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backpoz : MonoBehaviour
{
    public void backpoziomy()
    {
        SceneManager.LoadScene("Poziomy");
    }
    public void end ()
    {
        Application.Quit();
    }
}
