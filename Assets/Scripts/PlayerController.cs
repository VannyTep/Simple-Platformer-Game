using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Speed To Move Player Forward")]
    public float Speed;
    [Header("Speed To Make Player Jump")]
    public float Jump_Speed;

    [Space]
    
    [Header("Checking What Direction is The Player Move")]
    [SerializeField] float Horizontal_Move;

    [Space]

    [Header("Ground Systems")]
    [SerializeField] Transform GroundCheck_Point;
    [SerializeField] float GroundCheck_Range;
    [SerializeField] LayerMask WhatIsForGround;

    [Space]

    [Header("Facing System")]
    bool IsFacingRight;

    [Space]

    [Header("Components")]
    [SerializeField] Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal_Move = Input.GetAxis("Horizontal");

        // Jumping System
        Player_Jump_Method();
    }

    void FixedUpdate()
    {
        Player_Move_Method();

        // Facing Rgiht or Left Checking
        if (Horizontal_Move >= 0.01)
        {
            IsFacingRight = true;
            Player_Facing_Method();
        }
        else if (Horizontal_Move <= -0.01)
        {
            IsFacingRight = false;
            Player_Facing_Method();
        }

        Debug.Log(rb2d.velocity.y);
    }

    private void Player_Move_Method()
    {
        rb2d.velocity = new Vector2(Horizontal_Move * Speed * Time.deltaTime, rb2d.velocity.y);
    }

    private void Player_Jump_Method()
    {
        if (Ground_Check())
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb2d.AddForce(Vector2.up * Jump_Speed, ForceMode2D.Impulse);
                rb2d.gravityScale = 3;
                rb2d.drag = 4;   
            }
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            rb2d.gravityScale = 8;
            rb2d.drag = 4;  
        }      

        // if (rb2d.velocity.y < 0)
        // {
        //     rb2d.drag = 1;
        //     rb2d.gravityScale = 5;
        // }

        // if (rb2d.velocity.y > 0)
        // {
        //     rb2d.drag = 1;
        //     rb2d.gravityScale = 2;
        // }
    }

    private bool Ground_Check()
    {
        bool IsStayOnGround = Physics2D.OverlapCircle(GroundCheck_Point.position, GroundCheck_Range, WhatIsForGround);
        return IsStayOnGround;
    }

    private void Player_Facing_Method()
    {
        IsFacingRight = !IsFacingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
