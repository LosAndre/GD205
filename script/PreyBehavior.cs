using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreyBehavior : MonoBehaviour
{
    Rigidbody rb;
    public Transform predator;
    public float terrorForce = 10f;
    public string predatorTag, preyTag;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Vector3 predatorDirection = Vector3.Normalize(predator.position - transform.position);

        rb.AddForce(-predatorDirection * terrorForce);

        
    }
    void OnCollisionEnter(Collision myCollision)
    {
        if (myCollision.gameObject.CompareTag(predatorTag))
        {
            Destroy(myCollision.gameObject);
        }
        else if (myCollision.gameObject.CompareTag(preyTag))
        {
            Destroy(gameObject);
        }
    }
}