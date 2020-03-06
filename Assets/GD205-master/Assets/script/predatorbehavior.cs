using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class predatorbehavior : MonoBehaviour
{
    Rigidbody rb;
    public Transform prey;
    public float hungerForce = 10f;
    public string predatorTag, preyTag;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Vector3 preyDirection = Vector3.Normalize(prey.position - transform.position);

        rb.AddForce(preyDirection * hungerForce);
    }
    void OnCollisionEnter(Collision myCollision)
    {
        if (myCollision.gameObject.CompareTag(preyTag))
        {
            Destroy(myCollision.gameObject);
        }
        else if (myCollision.gameObject.CompareTag(predatorTag))
        {
            Destroy(gameObject);
        }
    }
}
