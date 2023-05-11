using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autodestruirse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Destroy this object if it goes out of the vision of the camera
        if (transform.position.y < -15 || transform.position.y > 15)
        {
            Destroy(gameObject);
        }
    }

    // Make a function that detects if the object is on camera
    
}
