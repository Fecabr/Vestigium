using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Item : MonoBehaviour
{
    //Esta variable llevara el conteo de nuestros puntos de los collectables que recolectemos
    public static int CollectableQuantity = 0;
    public Text CollectableTex;
    AudioSource audioPickUp;

    //
    ParticleSystem collectablePart;

     void Start()
    {
        collectablePart = GameObject.Find("CollectableParticles").GetComponent<ParticleSystem>();
        audioPickUp = GetComponentInParent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("Player"))
        {
        

            audioPickUp.Play();
            //Cambiar cada exploción de cada particula
            collectablePart.transform.position = transform.position;
            collectablePart.Play();
            Destroy(gameObject);
            CollectableQuantity += 10;
            CollectableTex.text = CollectableQuantity.ToString();
            //UpdateScoreLable(scorePlayer, CollectableQuantity);

            if (CollectableQuantity == 10)
            {
                SceneManager.LoadScene("WinScene");
            }
        }
        
    }
    //void UpdateScoreLable(Text label,int score)
    //{
    //    label.text = score.ToString();
    //}

    //private void OnCollisionEnter(Collision collision)
    //{
    //    audioPickUp.Play();
    //}



    //void OnGUI()
    //{
    //    GUI.Label(new Rect(Screen.width / 2, 10, 100, 100), "Botonn");
    //    GUI.Label(new Rect(Screen.width / 2, 10, 100, 100), "La puntación es " + GameManager.instance.points);
    //}
}
