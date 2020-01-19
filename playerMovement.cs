using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public float moveSpeed = 3f;
    float velX;
    float velY;
    Rigidbody2D rigBody;

   

    void Start()
    {
        rigBody = GetComponent<Rigidbody2D>();
        
    }

    

    // Update is called once per frame
    void Update()
    {
        velX = Input.GetAxisRaw ("Horizontal");
        velY = rigBody.velocity.y;
        rigBody.velocity = new Vector2(velX * moveSpeed, velY);
    }

    
    
}
