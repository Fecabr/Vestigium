using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemText : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //transform.Rotate(Vector3.down,Time.deltaTime * 200f);
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            //Debug.Log("Destruir");
        }
    }
}
