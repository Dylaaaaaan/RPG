using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    float vertical;
    float horizontal;


    public float speed = 5;
    public float turnSpeed = 2;

    Rigidbody2D body;
    PlayerData data;

	void Start ()
    {
        data = GetComponent<PlayerData>();
        body = GetComponent<Rigidbody2D>();
	}
	
	
	void Update ()
    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");
	}

    private void FixedUpdate()
    {
        //transform.Rotate rotates an object on the X, Y or Z axis
        transform.Rotate(0, 0, -(horizontal * turnSpeed));

        //transform.up stores the forward direction of the object
        body.velocity = transform.up * speed * vertical;

        if (data.Fuel > 0)
        {
            body.velocity = transform.up * speed * vertical;
            data.Fuel -= Mathf.Abs(vertical * 0.01f);
        }
    }

}
