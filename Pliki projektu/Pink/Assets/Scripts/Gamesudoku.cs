using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Gamesudoku : MonoBehaviour
{
    public string number;
    private string[] tab = new string[12] {"2", "3", "1", "4", "2", "1", "3", "2", "4", "2", "1", "3" };
    public string[] inserttab = new string[12];
    void Update()
    {
        int lose = 0;
        for (int i=0;i<=11;i++)
        {
            if(tab[i]==inserttab[i])
            {
                
            }
            else
            {
                lose = 1;
            }
        }
        if (lose == 0)
        {
            SceneManager.LoadScene("poziom4");
        }
        

    }
    public void OnButtonClick()
    {
        string num;
        var go = EventSystem.current.currentSelectedGameObject;
        if (go != null)
        {
            Button btn = go.GetComponent<Button>();
            num = btn.GetComponentInChildren<Text>().text;
            number = num;
        }
        else
            Debug.Log("currentSelectedGameObject is null");
    }
    public void OnButtonClickInput()
    {
        int numberofplace;
        string temp_name;
        //string number;
        //string number2;
        var go = EventSystem.current.currentSelectedGameObject;
        if (go != null && number !="0")
        {
            Button btn = go.GetComponent<Button>();
            btn.GetComponentInChildren<Text>().text = number;
            temp_name = go.name;
            //Debug.Log(temp_name.Length);
            if(temp_name.Length == 2)
            {
                numberofplace = int.Parse(temp_name.Substring(1,1));
            }
            else
            {
                numberofplace = int.Parse(temp_name.Substring(1, 2));
            }
            inserttab[numberofplace] = number;
            if(tab[numberofplace] == inserttab[numberofplace])
            {
                Color32 pinkcolor = new Color32(253, 56, 195, 0);
                btn.GetComponentInChildren<Image>().color = pinkcolor;
            }
        }
        else
            Debug.Log("currentSelectedGameObject is null");
    }
    GameObject place1;
    public void Showhelp()
    {
        place1 = GameObject.FindGameObjectWithTag("placeforhelp");
        if (place1.gameObject.GetComponent<Text>().text != "Tylko jedna w rzędzie i kolumnie")
        {
            place1.gameObject.GetComponent<Text>().text = "Tylko jedna w rzędzie i kolumnie";
            StartCoroutine(waiter());
        }
    }
    IEnumerator waiter()
    {
        //Wait for 4 seconds
        yield return new WaitForSeconds(5);
        place1 = GameObject.FindGameObjectWithTag("placeforhelp");
        place1.gameObject.GetComponent<Text>().text = "";

    }


}
