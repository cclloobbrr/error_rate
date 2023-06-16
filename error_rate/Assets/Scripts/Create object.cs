using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Createobject : MonoBehaviour
{
    public GameObject obj;
    float speed = 0.005f;
    public Transform left;
    private void Start() 
    {
     GameObject newobject = Instantiate(obj, new Vector2(10, 15), Quaternion.identity, transform) as GameObject;    


    }
    private void Update() 
    {
     if(Input.GetKeyUp(KeyCode.Space))   
        left.Translate(new Vector2(1, 0));
    }
}
