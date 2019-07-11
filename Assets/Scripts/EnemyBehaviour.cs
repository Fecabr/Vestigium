using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour {

    Rigidbody enemyRb;
    float timeBeForChame;
    public float delay = .5f;
    public float speed = .3f;
	// Use this for initialization
	void Start ()
    {
        enemyRb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        enemyRb.velocity = Vector2.right * speed;
        if (timeBeForChame < Time.time)
        {
            speed *= -1;
            timeBeForChame = Time.time + delay;
        }
	}
}
