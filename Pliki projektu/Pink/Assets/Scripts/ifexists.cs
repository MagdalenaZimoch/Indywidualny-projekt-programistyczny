using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ifexists : MonoBehaviour
{

    // Update is called once per frame

    void Update()
    {
        List<int> itemis = new List<int>();
        for (int i=1;  i<=21; i++)
        {
            string name = "s" + i;
            if(GameObject.Find(name) != null)
            {
                continue;
            }
            else
            {
                itemis.Add(1);
            }
        }
        if (itemis.Count == 21)
        {
            Debug.Log("wygrałeś");
            PlayerPrefs.SetInt("level_safe", 2);
            SceneManager.LoadScene("poziom2");
        }
    }
}
