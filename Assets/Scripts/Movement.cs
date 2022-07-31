using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float verticalSpeed = 3;
    float horizontalSpeed = 5;
    float hor;


    void Start()
    {
        
    }

    
    void Update()
    {
        Move();
    }

    private void Move()

    {
        hor = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontalSpeed * hor * Time.deltaTime, 0, verticalSpeed * Time.deltaTime)); 
    }
}
