using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Text myscore;
    private int score;
    GameObject[] plamki;
    void Start()
    {
        PlayerPrefs.SetInt("score", 21);
        score = 21;
        myscore.text = score.ToString();
    }
    
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "duszek1")
        {
            changescore();
        }
    }
    public void changescore()
    {
        Destroy(gameObject);
        score = PlayerPrefs.GetInt("score");
        //PlayerPrefs.DeleteKey("score");
        score--;
        PlayerPrefs.SetInt("score", score);
        myscore.text = score.ToString();
        if (score == 0)
        {
            Debug.Log("wygrana");
            PlayerPrefs.SetInt("level_safe", 2);
            //Debug.Log(PlayerPrefs.GetInt("level_safe"));
            PlayerPrefs.SetInt("score", 0);
            SceneManager.LoadScene("poziom2");
        }
    }
}
