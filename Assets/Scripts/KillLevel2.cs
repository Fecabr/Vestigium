using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KillLevel2 : MonoBehaviour {

    public Text playerLiferText;
    //public Text playerGameOver;
    public static int PlayerLifes = 3;
    public Transform portal;
    //Canvas que muestra el conteo.

    //public Text tiempoText;
    ////Contador
    //public float tiempo = 0.0f;


    private void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
          
            other.transform.position = portal.transform.position;
            other.transform.rotation = portal.transform.rotation;
            //LoseLife();
            //Debug.Log("Tiene de vida " + PlayerLifes.ToString());
            PlayerLifes = PlayerLifes - 1;

            playerLiferText.text = PlayerLifes.ToString();
            //Debug.Log("Chocaste");
            if (PlayerLifes == 0)
            {
                //playerGameOver.text = "Game Over";
                //Application.LoadLevel(Application.loadedLevel);
                PlayerLifes = 3;
                ItemLevel2.CollectableQuantity2 = 0;
                //ItemLevel2.CollectableQuantity2 = 0;
                //SceneManager.UnloadSceneAsync("MainScene");
                SceneManager.LoadScene("DeadSceneLevel2");
                
            }
            
            
        }
    }

}
