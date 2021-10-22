using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBallBehaviour : MonoBehaviour
{

    [SerializeField]
    private float force = 3f;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    public void Throw()
    {
        Debug.Log("hello");
        Vector3 forceVector = transform.forward * force;
        rb.AddForce(forceVector);
    }
}
