using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed = 5f;
    private void Update() 
    {
        if(Input.GetKey(KeyCode.W))
            transform.Translate(new Vector2(0, 1) * speed);
        
        if(Input.GetKey(KeyCode.A))
        transform.Translate(new Vector2(-1, 0) * speed);

        if(Input.GetKey(KeyCode.S))
            transform.Translate(new Vector2(0,-1) * speed);

        if(Input.GetKey(KeyCode.D))
            transform.Translate(new Vector2(1, 0) * speed);
    }
}
