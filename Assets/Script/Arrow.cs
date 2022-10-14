using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Arrow : MonoBehaviour
{

    Rigidbody2D playerObject;

    GameObject player;
    float playerStartPos;
    public float speed = 0.5f;
    

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerObject = GetComponent<Rigidbody2D>();
        playerStartPos = player.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {

        float movementValueX = -1.0f;
        float offset = (player.transform.position.x - playerStartPos) * speed;

        playerObject.velocity = new Vector2(movementValueX * speed, 0f);
    }

private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
    
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);



        }
    }
}
