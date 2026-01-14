using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Penguin : MonoBehaviour
{
    [SerializeField] private float _jumpHeight = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private SpriteRenderer _spriteRenderer;

    private bool _isGrounded = true;

    void Start()
    {

    }


    void Update()
    {

        float vertical = Input.GetAxis("Vertical") + _jumpHeight * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _isGrounded = false;
            transform.Translate(0, vertical, 0);
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("ground"))
        {
            _isGrounded = true;
        }
    }

}
