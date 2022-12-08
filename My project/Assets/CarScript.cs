using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    Rigidbody ourRigidBody;

    float carSpeed = 60f;
    float rotationspeed = 160;
    // Start is called before the first frame update
    void Start()
    {
        ourRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.back * Time.deltaTime;

            transform.position += carSpeed * transform.forward * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * Time.deltaTime;

            transform.position += carSpeed * transform.forward * Time.deltaTime;
            ourRigidBody.transform.Rotate(new Vector3(0, -1, 0), rotationspeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * Time.deltaTime;

            transform.position += carSpeed * transform.forward * Time.deltaTime;
            ourRigidBody.transform.Rotate(new Vector3(0, 1, 0), rotationspeed * Time.deltaTime);
        }
    }
}
