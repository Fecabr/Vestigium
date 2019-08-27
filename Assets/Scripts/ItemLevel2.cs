using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ItemLevel2 : MonoBehaviour {

    //Esta variable llevara el conteo de nuestros puntos de los collectables que recolectemos
    public static int CollectableQuantity2 = 0;
    public Text CollectableTex;
    //Este texto va a estar oculto
    public Text TextoIndice;
    AudioSource audioPickUp;

    //GameObjete para ser destruido cuando se recolecta el collectable
    public GameObject CollectableItem;
    //GameObjete de meta
    public GameObject gameMeta;
    ParticleSystem collectablePart;
    public float velocity;

    public Canvas canvas;

    public void Update()
    {
        transform.Rotate(Vector3.up,Time.deltaTime * velocity,Space.World);
    }

    void Start()
    {
        collectablePart = GameObject.Find("CollectableParticles").GetComponent<ParticleSystem>();
        audioPickUp = GetComponentInParent<AudioSource>();

        //canvas = canvas.GetComponent<Canvas>();
        //canvas.enabled = !canvas.enabled;
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            //canvas.enabled = true;
            //Inicia el audio 
            audioPickUp.Play();
            //Cambia la lectra a 14, ya que esta en 1
            TextoIndice.fontSize = 14;
            //Cambiar cada exploción de cada particula
            collectablePart.transform.position = transform.position;
            collectablePart.Play();
            Destroy(gameObject);
            Destroy(CollectableItem);
            CollectableQuantity2 += 10;
            CollectableTex.text = CollectableQuantity2.ToString();
            //UpdateScoreLable(scorePlayer, CollectableQuantity);

            if (CollectableQuantity2 == 50)
            {
                CollectableQuantity2 = 0;
                SceneManager.LoadScene("WinSceneLevel2");
            }

        }

    }

}
