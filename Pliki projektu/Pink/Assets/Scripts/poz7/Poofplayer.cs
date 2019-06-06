using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poofplayer : MonoBehaviour
{
    private float posx, posy;
    void Start()
    {
        posx = transform.position.x;
        posy = transform.position.y;
        PlayerPrefs.SetFloat("px", posx);
        PlayerPrefs.SetFloat("py", posy);
    }
    // Update is called once per frame
    void Update()
    {
        posx = PlayerPrefs.GetFloat("px");
        posy = PlayerPrefs.GetFloat("py");
        transform.position = new Vector2(posx,posy);
    }
}
