using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gyro : MonoBehaviour {

    private bool gyroEnabled;
    private Gyroscope gyro;
    public GameObject joystick;


    private GameObject cameraContainer;
    private Quaternion rot;



    // Use this for initialization
    void Start()
    {
        EnableGyro();
    }

    // Update is called once per frame
    void Update()
    {
        //Si el dispositivo tiene actiado el gyro
        if (gyroEnabled)
            transform.localRotation = gyro.attitude * rot;
    }

    private void EnableGyro()
    {
        //aca decide si usar el gyroscope o usar el el joystick
        if (SystemInfo.supportsGyroscope)
        {
            cameraContainer = new GameObject("Camera Container");
            cameraContainer.transform.position = transform.position;
            transform.SetParent(cameraContainer.transform);
            gyroEnabled = true;
            joystick.SetActive(false);
            gyro = Input.gyro;
            gyro.enabled = true;
            cameraContainer.transform.rotation = Quaternion.Euler(90f, 90f, 0f);
            rot = new Quaternion(0, 0, 1, 0);
            Debug.Log("Si soporta");
        }
        else
        {
            gyroEnabled = false;
            joystick.SetActive(true);
            Debug.Log("No soporta");
        }
    }
}
