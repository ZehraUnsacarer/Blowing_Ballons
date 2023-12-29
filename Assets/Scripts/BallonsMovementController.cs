using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonsMovementController : MonoBehaviour
{
    [SerializeField] private float speed;
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * speed, ForceMode.Impulse);
    }

    
}
