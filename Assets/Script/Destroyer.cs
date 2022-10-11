using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "CleanUp")
        {
            Destroy(collision.gameObject);
        }
        
        if (collision.gameObject.tag == "PickUp")
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
    
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);



        }
        

    }
}
