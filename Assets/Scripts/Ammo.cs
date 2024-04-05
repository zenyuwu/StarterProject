using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Ammo : MonoBehaviour
{
    [SerializeField] float speed = 1;
    [SerializeField] float lifespan = 0;
    Rigidbody rb;

    void Start()
    {
        if(lifespan > 0) Destroy(gameObject, lifespan);
        rb = GetComponent<Rigidbody>();    

        rb.AddRelativeForce(Vector3.forward * speed, ForceMode.VelocityChange);
    }

    void Update()
    {
        
    }
}
