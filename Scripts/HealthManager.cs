using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public float health;
    public float maxHealth;

    // Start is called before the first frame update
    void Start()
    {
        health = 100f;
        maxHealth = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        float amount = -1f*Time.deltaTime;
        updateHealth(amount);
    }

    void updateHealth(float amount){
        float proportion = amount/maxHealth;
        transform.position = transform.position + Vector3.right * 10 * proportion/2;
        transform.localScale = transform.localScale + Vector3.right * proportion;
        health += amount;
    }
}
