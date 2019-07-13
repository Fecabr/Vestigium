using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ItemLevel2 : MonoBehaviour {

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

            if (CollectableQuantity == 30)
            {
                CollectableQuantity = 0;
                SceneManager.LoadScene("WinSceneLevel2");
            }

        }

    }

}
