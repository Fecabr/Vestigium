using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Kill : MonoBehaviour {

    public Text playerLiferText;
    public Text playerGameOver;
    public static int PlayerLifes = 3;
    public Transform portal;

 

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
          
            other.transform.position = portal.transform.position;
            other.transform.rotation = portal.transform.rotation;
            //LoseLife();
            Debug.Log("Tiene de vida " + PlayerLifes.ToString());
            PlayerLifes = PlayerLifes - 1;

            playerLiferText.text = PlayerLifes.ToString();

            if (PlayerLifes == 0)
            {
                playerGameOver.text = "Game Over";
                //Application.LoadLevel(Application.loadedLevel);
                SceneManager.LoadScene("DeadScene");
            }
            
            
        }
    }

    //public void LoseLife()
    //{
    //    if (PlayerLifes > 1)
    //    {
    //        PlayerLifes--;
    //    }
    //    else
    //    {
    //        PlayerLifes = 0;
    //        //Mostrar Pantalle de Gameover
    //        Debug.Log("Moriste");
            

    //    }
    //}
}
