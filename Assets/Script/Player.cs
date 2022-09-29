using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   
    Rigidbody2D playerObject;
    
    public GameObject groundChecker;
    public LayerMask whatIsGround;

    float maxSpeed = 5.0f;
    bool isOnGround = false;
  
    

    // Start is called before the first frame update
    void Start()
    {
        playerObject = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float movementValueX = 1.0f;
       

        playerObject.velocity = new Vector2(movementValueX * maxSpeed, playerObject.velocity.y);

        isOnGround = Physics2D.OverlapCircle(groundChecker.transform.position, 0.0f, whatIsGround);

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true)
        {
            playerObject.AddForce(new Vector2(0.0f,500f));
        } else if (Input.GetKeyDown(KeyCode.W) && isOnGround == true)
        {
            playerObject.AddForce(new Vector2(0.0f, 500f));
        } else if (Input.GetKeyDown(KeyCode.S) && isOnGround == false)
        {
            playerObject.AddForce(new Vector2(0.0f, -500f));
        }

        if (Input.GetKey(KeyCode.D))
        {
            maxSpeed = 10.0f;
        } else if (Input.GetKey(KeyCode.A))
        {
            maxSpeed = 2.5f;
        }
        else
        {
            maxSpeed = 5.0f;
        }
        
    }
}
