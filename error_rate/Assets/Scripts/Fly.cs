using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{

    public GameObject obj;
    float speed = 0.1f;
    public  Transform fly;



    private void Update() 
    {
        fly.Translate(new Vector2(1, 0) * speed);        
    }

}
