using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] GameObject ammoPrefab;
    [SerializeField] Transform transform;
    [SerializeField] AudioSource fireSound;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(ammoPrefab, transform.position, transform.rotation);
            fireSound.Play();
        }
    }
}
