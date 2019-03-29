using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody2D m_ridcom;
    public Transform groundCheck;
    public float groundCheckradius;
    public LayerMask whatisground;
    private bool onGround;


    [SerializeField]
    int m_speed;
    int m_jump;
    // Start is called before the first frame update
    void Start()
    {
        m_ridcom = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        m_ridcom.velocity = new Vector2(3, m_ridcom.velocity.y);
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckradius, whatisground);




        

    }
}
