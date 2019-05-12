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

    void DestroyGameObject()
    {
        Destroy(gameObject);
        plamki = GameObject.FindGameObjectsWithTag("plamki");
        score = plamki.Length - 1;
        myscore.text = score.ToString();
        if (score == 0)
        {
            Debug.Log("wygrana");
            PlayerPrefs.SetInt("level_safe", 2);
            Debug.Log(PlayerPrefs.GetInt("level_safe"));
            SceneManager.LoadScene("poziom2");
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "duszek1")
        {
            DestroyGameObject();
        }
    }
}
