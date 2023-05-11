using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnear : MonoBehaviour
{
    public float interpolationPeriod;
    public float fuerza;
    float time;
    public GameObject proyectil;
    // Start is called before the first frame update
    void Start()
    {
        time = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        // Shoot a ball agains the direction of the object Pivote every five seconds
        if (time >= interpolationPeriod)
        {
            // Reset time as a random number between 0 and interpolationPeriod
            time = Random.Range(0f, interpolationPeriod);
            // make instance of prefab proyectil
            GameObject balita = Instantiate(proyectil, transform.position, Quaternion.identity);
            balita.GetComponent<Rigidbody>().AddForce(-transform.position * fuerza);
        }
    }
}
