using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Poziomyobraz : MonoBehaviour
{
    private int poziom;
    public Transform p1, p2, p3, p4, p5, p6, p7;
    // Start is called before the first frame update
    void Start()
    {
        poziom = PlayerPrefs.GetInt("zaladuj");
        Debug.Log(poziom);
        po1();
        po2();
        po3();
        po4();
        po5();
        po6();
        po7();
    }
    public void po1()
    {
            p1.GetComponent<Button>().interactable = true;
    }
    public void po2()
    {
        if (poziom < 2)
        {
            p2.GetComponent<Button>().interactable = false;
        }
        else
        {
            p2.GetComponent<Button>().interactable = true;
        }
    }
    public void po3()
    {
        if (poziom < 3)
        {
            p3.GetComponent<Button>().interactable = false;
        }
        else
        {
            p3.GetComponent<Button>().interactable = true;
        }
    }
    public void po4()
    {
        if (poziom < 4)
        {
            p4.GetComponent<Button>().interactable = false;
        }
        else
        {
            p4.GetComponent<Button>().interactable = true;
        }
    }
    public void po6()
    {
        if (poziom < 6)
        {
            p6.GetComponent<Button>().interactable = false;
        }
        else
        {
            p6.GetComponent<Button>().interactable = true;
        }
    }
    public void po5()
    {
        if (poziom < 5)
        {
            p5.GetComponent<Button>().interactable = false;
        }
        else
        {
            p5.GetComponent<Button>().interactable = true;
        }
    }
    public void po7()
    {
        if (poziom < 7)
        {
            p7.GetComponent<Button>().interactable = false;
        }
        else
        {
            p7.GetComponent<Button>().interactable = true;
        }
    }
}
