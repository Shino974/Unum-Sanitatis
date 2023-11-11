using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public Transform groundCheck;
    public LayerMask groundLayer;
    private bool _isGrounded;
    [SerializeField] private int jumpPower;
    
    private Rigidbody2D _body;
    // Start is called before the first frame update
    void Start()
    {
        _body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _isGrounded = Physics2D.OverlapCapsule(groundCheck.position, new Vector2(0.5f, 0.3f), CapsuleDirection2D.Horizontal, 0, groundLayer);

        if (Input.GetButtonDown(
                "Jump") && _isGrounded)
            _body.velocity = new Vector2(_body.velocity.x, jumpPower);        
    }
}
