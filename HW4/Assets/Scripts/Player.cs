using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    [Header("Jump")]
    public float jumpForce = 6f;
    private Rigidbody2D _rb;
    private bool _isDead = false;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (_isDead)
            return;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
            _isGrounded = false;
        }
    }
    
    private void Jump()
    {
        _rb.velocity = new Vector2(_rb.velocity.x, 0f);
        _rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        GameController.Instance?.PlayerFlap();
    }
    public void Die()
    {
        _isDead = true;
    }

    private bool _isGrounded = false;

    private void OnCollisionEnter2D (Collision2D collision)
    {
        if (_isDead)
            return;

        if (collision.gameObject.CompareTag("Ground"))
        {
            _isGrounded = true;
            return;
        }

        if (collision.gameObject.CompareTag("Pipe"))
        {
            GameController.Instance.GameOver();
            Die();
        }
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _isGrounded = false;
        }
    }
}
