using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipControl : MonoBehaviour
{
    public GameObject MissileCloneTemplate;
    
    Vector3 velocity, acceleration;
    float rotationspeed = 180;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            acceleration = transform.forward;

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 0, 1), rotationspeed*Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, 0, -1), rotationspeed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(new Vector3(1, 0, 0), rotationspeed * Time.deltaTime);

        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            fireMissile();
        }
        velocity += acceleration * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;

    }

    private void fireMissile()
    {
        Instantiate(MissileCloneTemplate, transform.position, transform.rotation);
    }
}
