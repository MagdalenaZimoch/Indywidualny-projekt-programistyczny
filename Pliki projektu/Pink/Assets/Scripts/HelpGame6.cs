using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpGame6 : MonoBehaviour
{
    [SerializeField]
    public Image placeforhelp;
    private Color32 wisible = new Color32 (255,255,255,255);
    private Color32 inwisible = new Color32(255, 255, 255, 0);
    private Color32 now;

    public void Openhelp()
    {
        now = placeforhelp.color;
        //Debug.Log(now);
        placeforhelp.color = wisible;

        StartCoroutine(Waiter());

    }
    IEnumerator Waiter()
    {
        yield return new WaitForSeconds(2);
        placeforhelp.color = inwisible;

    }
}
