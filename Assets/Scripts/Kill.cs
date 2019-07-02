using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour {

    public Transform portal;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
          
            other.transform.position = portal.transform.position;
            other.transform.rotation = portal.transform.rotation;
            GameManager.instance.LoseLife();
            
        }
    }
}
