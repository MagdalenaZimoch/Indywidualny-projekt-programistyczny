using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("R", 0);
        PlayerPrefs.SetFloat("G", 0);
        PlayerPrefs.SetFloat("B", 0);
        if (PlayerPrefs.GetInt("zaladuj") < 4)
        {
            PlayerPrefs.SetInt("zaladuj", 4);
        }
        //Debug.Log(PlayerPrefs.GetInt("zaladuj"));
    }
    public Image img;
    public Text helpText;

    void Update()
    {
        byte r =(byte) PlayerPrefs.GetInt("R");
        byte g =(byte) PlayerPrefs.GetInt("G");
        byte b =(byte) PlayerPrefs.GetInt("B");
        //string czytaj = PlayerPrefs.GetInt("R").ToString() + " " + PlayerPrefs.GetInt("G").ToString() +" "+ PlayerPrefs.GetInt("B").ToString();
        Color32 newCOLOR = new Color32(r,g,b,255);
        img.color = newCOLOR;
        Sprawdz((int)r, (int)g, (int)b);
    }
    void Sprawdz(int r,int g,int b)
    {
        int sr,sg,sb;

        if(r > 195 && r < 205)
        {
            sr = 1;
        }
        else
        {
            sr = 0;
        }
        if(g > 152 && g < 162)
        {
            sg = 1;
        }
        else
        {
            sg = 0;
        }
        if (b > 195 && b < 205)
        {
            sb = 1;
        }
        else
        {
            sb = 0;
        }
        if(sr == 1 && sb == 1 && sg == 1)
        {
            Debug.Log("Wygrłeś");
            SceneManager.LoadScene("poziom5");
        }

    }

    public Slider mainSliderR;
    public Slider mainSliderG;
    public Slider mainSliderB;
    public Text textB;
    public Text textG;
    public Text textR;
    //Invoked when a submit button is clicked.
    public void SubmitSliderR()
    {
        //Displays the value of the slider in the console.
        //Debug.Log(mainSliderR.value);
        textR.text = mainSliderR.value.ToString();
        int r = (int) mainSliderR.value;
        PlayerPrefs.SetInt("R", r);
    }
    public void SubmitSliderG()
    {
        //Displays the value of the slider in the console.
        //Debug.Log(mainSliderG.value);
        textG.text = mainSliderG.value.ToString();
        int g = (int) mainSliderG.value;
        PlayerPrefs.SetInt("G", g);
    }
    public void SubmitSliderB()
    {
        //Displays the value of the slider in the console.
        //Debug.Log(mainSliderB.value);
        textB.text = mainSliderB.value.ToString();
        int b = (int) mainSliderB.value;
        PlayerPrefs.SetInt("B", b);
    }
    public void Openhelp()
    {
        if(helpText.text != "200,157,...")
        {
            helpText.text = "200,157,...";
            StartCoroutine(Waiter());

        }
        else
        {
            Debug.Log("nie udalo sie");
        }
    }
    IEnumerator Waiter()
    {
        yield return new WaitForSeconds(5);
        helpText.text = "";
    }
}
