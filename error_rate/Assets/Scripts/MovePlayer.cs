using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed = 10f;

    private Rigidbody2D rb;
    private Vector2 moveVector;
    private void Awake() 
    {
       Rigidbody2D _rb = GetComponent<Rigidbody2D>();    
    }

    private void FixedUpdate() 
    {
        Vector2 move = new Vector2 (Input.GetAxis("Horizontal"), (Input.GetAxis("Vertical")));
        transform.position = transform.position + move * speed * Time.deltaTime;
    }
}
