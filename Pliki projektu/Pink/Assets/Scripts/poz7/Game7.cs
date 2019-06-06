using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game7 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private bool przegrana;
    private GameObject player;
    private Vector2 place;
    private float placex, placey;
    private GameObject[] poles;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("mylayer");
        PlayerPrefs.SetInt("score", 0);
        if (PlayerPrefs.GetInt("zaladuj") < 7)
        {
            PlayerPrefs.SetInt("zaladuj", 7);
        }
        //Debug.Log(PlayerPrefs.GetInt("zaladuj"));

    }
    void Update()
    {
        poles = GameObject.FindGameObjectsWithTag("klocki");
        int s = PlayerPrefs.GetInt("score");
        if(s == 53)
        {
            Debug.Log("wygrana");
            SceneManager.LoadScene("poziom8");
        }
    }

    public void Klikgora()
    {
        //Debug.Log("Góra");
        //place = new Vector2(player.GetComponent<Transform>().position.x,player.GetComponent<Transform>().position.y);
        //Debug.Log(place);
        
        placex = player.GetComponent<Transform>().position.x;
        placey = player.GetComponent<Transform>().position.y + 6.0f;
        //player.GetComponent<Transform>().position = new Vector2(placex, placey);
        PlayerPrefs.SetFloat("px", placex);
        PlayerPrefs.SetFloat("py", placey);

    }
    public void Klikdol()
    {
        //Debug.Log("Dól");
        placex = player.GetComponent<Transform>().position.x;
        placey = player.GetComponent<Transform>().position.y - 6.0f;
        //player.GetComponent<Transform>().position = new Vector2(placex, placey);
        PlayerPrefs.SetFloat("px", placex);
        PlayerPrefs.SetFloat("py", placey);
    }
    public void Klikprawo()
    {
        //Debug.Log("Prawo");
        placex = player.GetComponent<Transform>().position.x + 6.0f;
        placey = player.GetComponent<Transform>().position.y;
        //player.GetComponent<Transform>().position = new Vector2(placex, placey);
        PlayerPrefs.SetFloat("px", placex);
        PlayerPrefs.SetFloat("py", placey);
    }
    public void Kliklewo()
    {
        //Debug.Log("Lewo");
        placex = player.GetComponent<Transform>().position.x - 6.0f;
        placey = player.GetComponent<Transform>().position.y;
        //player.GetComponent<Transform>().position = new Vector2(placex, placey);
        PlayerPrefs.SetFloat("px", placex);
        PlayerPrefs.SetFloat("py", placey);
    }
    public Text t1, t2;
    public void ShowHelp()
    {
        if (t1.text != "Trójkąty pozwalają się ruszać")
        {
            t1.text = "Trójkąty pozwalają się ruszać";
            t2.text = "Pozbądź się białych";
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
