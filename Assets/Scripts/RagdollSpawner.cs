using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollSpawner : MonoBehaviour
{
    [SerializeField] GameObject ragdoll;

    void Update()
    {
        if(Input.GetKey(KeyCode.Space)) {
            Instantiate(ragdoll, transform.position, Quaternion.identity);
        }
    }
}
