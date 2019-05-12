using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class colision : MonoBehaviour
{
    void Start()
    {
    }
    void DestroyGameObject()
    {
        Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "duszek1")
        {
            DestroyGameObject();
        }
    }

}