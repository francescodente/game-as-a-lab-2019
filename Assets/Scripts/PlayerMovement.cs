using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 7;

    private Rigidbody rb;
    private Vector3 currentVelocity;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + currentVelocity * Time.fixedDeltaTime);
    }

    public void SetDirection(Vector3 direction)
    {
        currentVelocity = direction * speed;
    }

    public void LookAt(Vector3 targetPoint)
    {
        transform.LookAt(targetPoint);
    }
}
