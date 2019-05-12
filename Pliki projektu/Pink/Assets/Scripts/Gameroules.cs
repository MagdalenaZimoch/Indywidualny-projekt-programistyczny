using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Gameroules : MonoBehaviour
{
    //k5,k8,k7,b1,k3,b3,k2,k6,b5,b4,k4,b2,k1
    private string[] keys = new string[13] {"k5", "k8", "k7", "b1", "k3", "b3", "k2", "k6", "b5", "b4", "k4", "b2", "k1"};
    public string[] keys_klik = new string[13];
    public int number = 0;

    private void Reset()
    {
        for(int i=0;i<=12;i++)
        {
            keys_klik[i] = null;   
        }
        number = 0;
    }
    public void OnButtonClick()
    {
        var go = EventSystem.current.currentSelectedGameObject;
        if (go != null)
        {
            Debug.Log("Clicked on : " + go.name);
            keys_klik[number] = go.name;
            Debug.Log(keys_klik.Length);
            Debug.Log(keys.Length);
            Sprawdz();
            
        }
        else
            Debug.Log("currentSelectedGameObject is null");
    }
    private void Sprawdz()
    {
        int check = 0;
        if (number < 12)
        {
            for (int i = 0; i <= number; i++)
            {
                if (keys_klik[i] == keys[i])
                {
                    continue;
                }
                else
                {
                    Reset();
                    Debug.Log("ZRESETOWANO");
                    check = 1;
                }
            }
            if (check == 0)
                number++;
        }
        else if (number == 12)
        {
            for (int i = 0; i <= number; i++)
            {
                if (keys_klik[i] == keys[i])
                {
                    if (i == 12)
                    {
                        Debug.Log("wygrana");
                        PlayerPrefs.SetInt("level_safe", 3);
                        SceneManager.LoadScene("poziom3");
                        
                    }
                }
                else
                {
                    Reset();
                    Debug.Log("ZRESETOWANO");
                }
            }
        }
        else
        {
            Reset();
            number = 0;
        }
    }

}
