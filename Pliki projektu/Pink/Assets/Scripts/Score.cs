using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public Text myscore = null;
    GameObject[] Numberofs;
    // Start is called before the first frame update
    void Start()
    {
        myscore.text = "21";
    }

    // Update is called once per frame
    void Update()
    {
        
        for (int i=1;i<=21;i++)
        {
            string nameofs = "s" + i.ToString();
            Numberofs = GameObject.FindGameObjectsWithTag(nameofs);
        }
        Debug.Log(Numberofs.Length);
    }
}
