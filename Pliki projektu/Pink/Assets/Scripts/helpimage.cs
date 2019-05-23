using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class helpimage : MonoBehaviour
{
    public Sprite podpowiedz2;
    private Sprite puste;
    GameObject place1;

    public void openhelp()
    {
        
        place1 = GameObject.FindGameObjectWithTag("placeforhelp");
        if (place1.gameObject.GetComponent<SpriteRenderer>().sprite != podpowiedz2)
        {
            place1.gameObject.GetComponent<SpriteRenderer>().sprite = podpowiedz2;
            StartCoroutine(waiter());
        }
        else
        {
            
        }
    }
    IEnumerator waiter()
    {
        //Wait for 4 seconds
        yield return new WaitForSeconds(5);
        place1 = GameObject.FindGameObjectWithTag("placeforhelp");
        place1.gameObject.GetComponent<SpriteRenderer>().sprite = puste;

    }


}
