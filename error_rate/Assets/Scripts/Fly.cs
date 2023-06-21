using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{

    public GameObject obj;
    float speed = 0.1f;
    public  Transform fly;
    public int y;
    public int x;





    private void Update() 
    {
        fly.Translate(new Vector2(x, y) * speed);        
    }
        
}
