using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KunaiHandler : MonoBehaviour
{
    public float speed = 5f;
    private void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * speed,ForceMode.VelocityChange);
        Destroy(gameObject, 5f);
    }
}
