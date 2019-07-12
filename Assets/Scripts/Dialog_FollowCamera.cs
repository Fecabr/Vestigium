using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog_FollowCamera : MonoBehaviour {
    public GameObject cameraReference;
    private Quaternion newRotation;
    private Vector3 newRotationEuler;
    private float newRotationY;
    private float targetRotation;
	// Use this for initialization
	void Start () {
        newRotation = Quaternion.identity;
        newRotationEuler = Vector3.zero;
    }
	
	// Update is called once per frame
	void Update () {
        targetRotation = cameraReference.transform.rotation.eulerAngles.y;
        targetRotation = (targetRotation > 180) ? targetRotation - 360 : targetRotation;
        newRotationY = Mathf.Lerp(newRotationEuler.y, targetRotation, Time.deltaTime);        
        newRotationEuler.y = newRotationY;
        newRotation.eulerAngles = newRotationEuler;
        this.transform.rotation = newRotation;
        //QUITAR PARA ANDROID
        this.transform.position = cameraReference.transform.position;       
    }
}
