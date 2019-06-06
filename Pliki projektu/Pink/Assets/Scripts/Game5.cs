using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game5 : MonoBehaviour
{
    void Start()
    {
        if (PlayerPrefs.GetInt("zaladuj") < 5)
        {
            PlayerPrefs.SetInt("zaladuj", 5);
        }
        //Debug.Log(PlayerPrefs.GetInt("zaladuj"));
    }
    private int i = 0;
    void Update()
    {
        if(i>13)
        {
            Debug.Log("wygrana");
            SceneManager.LoadScene("poziom6");
        }
    }
    public void Destroy()
    {
        Color32 black = new Color32(0, 0, 0, 255);
        var go = EventSystem.current.currentSelectedGameObject;
        if (go != null)
        {
            Button btn = go.GetComponent<Button>();
            if(btn.GetComponentInChildren<Image>().color != black)
            {
                btn.GetComponentInChildren<Image>().color = black;
                i++;
            }
            

        }
        else
            Debug.Log("currentSelectedGameObject is null");
    }
    public Text t1, t2;
    public void ShowHelp()
    {
        if(t1.text != "Nic tu nie ma")
        {
            t1.text = "Nic tu nie ma";
            t2.text = "Nic tu nie ma";
            StartCoroutine(waiter());
        }
    }
    
    IEnumerator waiter()
    {
        yield return new WaitForSeconds(5);
        t1.text = "";
        t2.text = "";

    }

}
