using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube2Script : MonoBehaviour
{
    Rigidbody ourRigidBody;

    // Start is called before the first frame update
    void Start()
    {
     ourRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ourRigidBody.AddExplosionForce(1000, transform.position + Vector3.down + Vector3.back, 3);
        }
    }
}
