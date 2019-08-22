using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    public Text tiempoText;
    public float tiempo = 0.0f;
    // Use this for initialization
  
	
	// Update is called once per frame
	void Update () {
        tiempo = tiempo - 1;
        tiempoText.text = "" + tiempo.ToString("f0");
        if (tiempo == 0.0)
        {
            SceneManager.LoadScene("DeadSceneLevel2");
        }
        
    }


}
