using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour {

    // Use this for initialization
    public GameObject obstacule;

	void Start () {
        //obstacule = GameObject.Find("Obstacle").GetComponent<GameObject>();
        //obstacule = obstacule.GetComponent<GameObject>();
        obstacule.SetActive(false);
        //obstaculo.SetActive(false);
        
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(obstacule);
           obstacule.SetActive(true);
            Debug.Log("Crusaste");
        }
    }
}
