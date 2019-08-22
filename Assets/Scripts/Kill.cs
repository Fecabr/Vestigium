using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Kill : MonoBehaviour {

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
        //tiempo -= Time.deltaTime;
        //tiempoText.text = "" + tiempo.ToString("f0");

        //if (tiempo == 0)
        //{
        //    PlayerLifes = 0;
        //    SceneManager.LoadScene("DeadScene");
        //}
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
                Item.CollectableQuantity = 0;
                //SceneManager.UnloadSceneAsync("MainScene");
                SceneManager.LoadScene("DeadScene");
                
            }
            
            
        }
    }

}
