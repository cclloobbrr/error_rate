using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject CHLEN;

    public Transform spe;

    float speed = -0.02f;


    private void Start() 
    {

    }

    private void Update() 
    {
        spe.Translate(new Vector2(1, 0) * speed);
    }
}
