using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Coins : MonoBehaviour
{

    [SerializeField] public float speed = 4.0f;
    [SerializeField] private Collider2D coincollider;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.position.x  < -10)
        {
            Destroy(gameObject);
        }
    }
}
