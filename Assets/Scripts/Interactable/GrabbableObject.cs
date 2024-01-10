using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbableObject : MonoBehaviour
{
    private Rigidbody rb;
    private Transform objectGrabPointTransform;
    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void Grab(Transform objectGrabPointTransform)
    {
        this.objectGrabPointTransform = objectGrabPointTransform;
        rb.useGravity = false;
        rb.isKinematic = true;
    }

    public void Drop()
    {
        rb.useGravity = true;
        objectGrabPointTransform = null;
        rb.isKinematic = false;
    }
    private void FixedUpdate()
    {
        if (objectGrabPointTransform != null)
        {
            float lerpSpeed = 10f;
            Vector3 newPosition = Vector3.Lerp(transform.position, objectGrabPointTransform.position, Time.deltaTime * lerpSpeed);
            rb.MovePosition(newPosition); 
        }
    }
}
