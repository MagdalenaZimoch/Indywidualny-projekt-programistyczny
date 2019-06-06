using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GAME1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("zaladuj") <= 1)
        {
            PlayerPrefs.SetInt("zaladuj", 1);
            PlayerPrefs.SetInt("p1", 1);
            
        }
        Debug.Log(PlayerPrefs.GetInt("zaladuj"));
        
    }
    public Text helpplace;
    public void Openhelp()
    {
        int ile = PlayerPrefs.GetInt("score");
        string tekst = "zostało: "+ile;
        helpplace.text = tekst;
        StartCoroutine(Waiter());

    }
    IEnumerator Waiter()
    {
        yield return new WaitForSeconds(5);
        helpplace.text = "";
    }
}
