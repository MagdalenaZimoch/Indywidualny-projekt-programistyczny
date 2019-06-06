using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Onplamki : MonoBehaviour
{
    [SerializeField]
    private float posx, posy;
    private float px, py;
    //private string pozycja;

    // Start is called before the first frame update
    void Start()
    {
        posx = transform.position.x;
        posy = transform.position.y;
        //pozycja = posx.ToString() + " " + posy.ToString();
        //Debug.Log(pozycja);
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
        if (rx <= 2.0f && ry <= 2.0f)
        {

            SceneManager.LoadScene("poziom7");

        }

    }
}