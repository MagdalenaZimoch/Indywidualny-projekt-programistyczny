using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SC : MonoBehaviour
{
    public void LoadLevel ()
    {
        PlayerPrefs.SetString("poprzednia", "Menu");
        SceneManager.LoadScene("Poziomy");
    }
    public void Startlvl1 ()
    {
        PlayerPrefs.SetString("poprzednia", "Poziomy");
        SceneManager.LoadScene("poziom1");
    }
    public void Startlvl2 ()
    {
        PlayerPrefs.SetString("poprzednia", "Poziomy");
        SceneManager.LoadScene("poziom2");
    }
    public void Startlvl3()
    {
        PlayerPrefs.SetString("poprzednia", "Poziomy");
        SceneManager.LoadScene("poziom3");
    }
    public void Startlvl4()
    {
        PlayerPrefs.SetString("poprzednia", "Poziomy");
        SceneManager.LoadScene("poziom4");
    }
    public void Startlvl5()
    {
        PlayerPrefs.SetString("poprzednia", "Poziomy");
        SceneManager.LoadScene("poziom5");
    }
    public void Startlvl6()
    {
        PlayerPrefs.SetString("poprzednia", "Poziomy");
        SceneManager.LoadScene("poziom6");
    }
    public void Startlvl7()
    {
        PlayerPrefs.SetString("poprzednia", "Poziomy");
        SceneManager.LoadScene("poziom7");
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
    public void Zaladuj()
    {
        PlayerPrefs.SetString("poprzednia", "Menu");
        int poziom = PlayerPrefs.GetInt("zaladuj");
        if (poziom>0)
        {
            string otworz = "poziom" + poziom;
            SceneManager.LoadScene(otworz);
        }
        else
        {
            SceneManager.LoadScene("poziom1");
        }
    }
    public void Wroc()
    {
        string gdzie = PlayerPrefs.GetString("poprzednia");
        SceneManager.LoadScene(gdzie);
    }
    public void Reset()
    {
        PlayerPrefs.SetInt("zaladuj", 1);
    }
}
