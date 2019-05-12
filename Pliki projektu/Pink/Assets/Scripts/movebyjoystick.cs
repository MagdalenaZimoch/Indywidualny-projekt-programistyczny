using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movebyjoystick : MonoBehaviour
{
    public Rigidbody2D m_ridcom;
    public float horizontalMove = 0f;
    public float verticalMove = 0f;
    public Joystick joystick;
    readonly int m_speed = 3;

    [SerializeField]
     // Start is called before the first frame update
    void Start()
    {
        m_ridcom = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        horizontalMove = joystick.Horizontal * m_speed;
        verticalMove = joystick.Vertical * m_speed;
        m_ridcom.velocity = new Vector2(horizontalMove,verticalMove);

    }
}
