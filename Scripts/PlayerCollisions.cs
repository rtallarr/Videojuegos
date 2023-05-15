using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollisions : MonoBehaviour
{
    
    
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected");
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Proyectil")
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Muralla")
        {
            // Change scene to the game over scene
            Debug.Log("Game Over");
            SceneManager.LoadScene("GameOver");
        }
    }
}
