using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Penguin : MonoBehaviour
{
    [SerializeField] private float _jumpHeight = 5.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Collider2D playercollider;
    [SerializeField] private CoinManager coinManager;
    private bool _isGrounded = true;

    void Update()
    {
        if (_isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x,_jumpHeight);
            _isGrounded = false;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Ground"))
        {
            _isGrounded = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collide)
    {
        
        if (collide.gameObject.tag.Equals("Coin"))
        {
            coinManager.AddCoin();
            Destroy(collide.gameObject);
        }
    }

}
