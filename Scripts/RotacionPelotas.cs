using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionPelotas : MonoBehaviour
{
    public float speed;
    public int sentido;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Make the object Pivote rotate
        transform.Rotate(new Vector3(0, 0, speed * sentido) * Time.deltaTime);

        // If the player presses spacebar, the rotation direction changes
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sentido *= -1;
        }
        
    }
}
