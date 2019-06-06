using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("zaladuj")<2)
        {
            PlayerPrefs.SetInt("zaladuj", 2);
        }
        //Debug.Log(PlayerPrefs.GetInt("zaladuj"));
    }

}
