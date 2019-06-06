using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("zaladuj") < 3)
        {
            PlayerPrefs.SetInt("zaladuj", 3);
        }
        //Debug.Log(PlayerPrefs.GetInt("zaladuj"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
