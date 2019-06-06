using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Delonplayer : MonoBehaviour
{
    [SerializeField]
    private float posx, posy;
    private float px, py;
    private int byl, czar,obecnie;
    //private string pozycja;

    // Start is called before the first frame update
    void Start()
    {
        posx = transform.position.x;
        posy = transform.position.y;
        //pozycja = posx.ToString() + " " + posy.ToString();
        //Debug.Log(pozycja);
    }
    void DestroyGameObject()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        px = PlayerPrefs.GetFloat("px");
        py = PlayerPrefs.GetFloat("py");
        //Debug.Log(px);
        //Debug.Log(py);
        float rx = Mathf.Abs(px - posx);
        float ry = Mathf.Abs(py - posy);
        //Debug.Log(rx);
        //Debug.Log(ry);
        if (rx <= 2.0f && ry <= 2.0f && byl == 0 && obecnie == 0)
        {
            int score = PlayerPrefs.GetInt("score");
            score++;
            PlayerPrefs.SetFloat("px", posx);
            PlayerPrefs.SetFloat("py", posy);
            obecnie = 1;
            Color32 czarny = new Color32(0, 0, 0, 255);
            gameObject.GetComponent<Renderer>().material.color = czarny;
            PlayerPrefs.SetInt("score", score);
        }
        else if(rx == 0.0f && ry == 0.0f && obecnie == 1)
        {
            byl = 1;
        }
        else if(rx > 2.0f && ry > 2.0f && byl == 1)
        {
            obecnie = 0;
        }

        else if(rx <= 2.0f && ry <= 2.0f && byl == 1)
        {
            Debug.Log("PRZEGRANA");
            PlayerPrefs.SetInt("score", 0);
            SceneManager.LoadScene("poziom7");
        }

    }

}
