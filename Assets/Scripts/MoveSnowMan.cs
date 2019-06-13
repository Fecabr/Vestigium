using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSnowMan : MonoBehaviour {

    private Rigidbody rb;

    private float vertical;
    private float horizontal;

    private Vector3 movement;

    private float speed = 6f;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        vertical = Input.GetAxisRaw("Vertical");
        horizontal = Input.GetAxisRaw("Horizontal");

        Move(vertical,horizontal);
        Turn(vertical,horizontal);
	}

    private void Move(float v, float h)
    {
        movement.Set(h,0,v);
        movement = movement.normalized * speed * Time.deltaTime;

        rb.MovePosition(transform.position + movement);
    }

    void Turn(float v, float h)
    {
        movement.Set(h,0,v);
        if (movement != Vector3.zero)
        {
            Quaternion newRotation = Quaternion.LookRotation(movement);
            rb.rotation = newRotation;
        }
    }

}
