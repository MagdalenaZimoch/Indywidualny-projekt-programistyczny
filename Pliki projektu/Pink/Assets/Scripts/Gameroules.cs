using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gameroules : MonoBehaviour
{
    //k5,k8,k7,b1,k3,b3,k2,k6,b5,b4,k4,b2,k1
    private string[] keys = new string[13] {"k5", "k8", "k7", "b1", "k3", "b3", "k2", "k6", "b5", "b4", "k4", "b2", "k1"};
    public string[] keys_klik = new string[13];
    private GameObject[] keysreset;
    private GameObject[] keysresetb;
    public int number = 0;
    private Button btnonclick;
    private Color newcolor;


    private void Reset()
    {
        for(int i=0;i<=12;i++)
        {
            keys_klik[i] = null;
        }
        number = 0;
        if (keysreset == null)
        {
            keysreset = GameObject.FindGameObjectsWithTag("kays");
        }
        if (keysreset != null)
        {
            Color32 color2 = new Color32(255, 255, 255, 255);

            for(int i=0; i<=7; i++)
            {
                keysreset[i].GetComponent<Image>().color = color2;
            }
            
        }
        if (keysresetb == null)
        {
            keysresetb = GameObject.FindGameObjectsWithTag("kaysb");
        }
        if (keysresetb != null)
        {
            Color32 color2 = new Color32(0, 0, 0, 255);

            for (int i = 0; i <= 4; i++)
            {
                keysresetb[i].GetComponent<Image>().color = color2;
            }

        }
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
            Sprawdz(go);
        }
        else
            Debug.Log("currentSelectedGameObject is null");
    }
    private void Sprawdz(GameObject on)
    {
        int check = 0;
        if (number < 12)
        {
            for (int i = 0; i <= number; i++)
            {
                if (keys_klik[i] == keys[i])
                {
                    Color32 color2 = new Color32(215, 2, 124, 255);
                    on.GetComponent<Image>().color = color2;
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
