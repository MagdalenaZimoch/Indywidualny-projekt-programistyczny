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
    public void Startlvl1 ()
    {
        SceneManager.LoadScene("poziom1");
    }
    public void Startlvl2 ()
    {
        SceneManager.LoadScene("poziom2");
    }
    public void Openmenu()
    {
        SceneManager.LoadScene("menu");
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void OpenFromSave()
    {
        if(PlayerPrefs.GetInt("level_save")!=0)
        { 
            Debug.Log("jest");
            string name = "poziom"+ PlayerPrefs.GetInt("level_save").ToString();
            Debug.Log(name);
            SceneManager.LoadScene(name);
        }
        else
        {
            Debug.Log("NIE MA");
            PlayerPrefs.SetInt("level_save", 1);
            SceneManager.LoadScene("poziom1");
        }
        
    }
}
