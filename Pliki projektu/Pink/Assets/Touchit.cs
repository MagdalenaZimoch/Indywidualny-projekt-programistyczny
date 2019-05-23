using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Touchit : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_InputField input;
    private TouchScreenKeyboard keyboard;
    void Start()
    {
        keyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.NumberPad);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
