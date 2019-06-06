using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game6 : MonoBehaviour
{
    
    [SerializeField]
    private Transform place;
    private Vector2 InitialPosition;
    private float deltaX, deltaY;
    private bool locked;
    

    // Start is called before the first frame update
    void Start()
    {
        InitialPosition = transform.position;
        //Debug.Log(InitialPosition);
        PlayerPrefs.SetInt("pkt", 0);
        if (PlayerPrefs.GetInt("zaladuj") < 6)
        {
            PlayerPrefs.SetInt("zaladuj", 6);
        }
        Debug.Log(PlayerPrefs.GetInt("zaladuj"));

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && !locked)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 TouchPosi = Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(TouchPosi))
                    {
                        deltaX = TouchPosi.x - transform.position.x;
                        deltaY = TouchPosi.y - transform.position.y;
                    }
                    break;

                case TouchPhase.Moved:
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(TouchPosi))
                        transform.position = new Vector2(TouchPosi.x - deltaX, TouchPosi.y - deltaY);
                    break;

                case TouchPhase.Ended:
                    if(Mathf.Abs(transform.position.x - place.position.x) <=0.5f &&
                        Mathf.Abs(transform.position.y - place.position.y)<=0.5f)
                    {
                        transform.position = new Vector2 (place.position.x, place.position.y);
                        locked = true;
                        int i = PlayerPrefs.GetInt("pkt");
                        i++;
                        PlayerPrefs.SetInt("pkt", i);
                    }
                    else
                    {
                        transform.position = new Vector2(InitialPosition.x, InitialPosition.y);
                    }
                    break;

               
            }
        }
        if(PlayerPrefs.GetInt("pkt")==7)
        {
            Debug.Log("WYGRANA");
            SceneManager.LoadScene("poziom7");
        }

    }

}

