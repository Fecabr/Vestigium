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
    //Este texto estara oculto una vez el gamer recolecte un collectable aparecera en la parte izquierda.
    public Text textoPortada;
    public GameObject CollectableItem; //Item que esta arriba del del collectable
    AudioSource audioPickUp;

    //Variables para el manejo del tiempo
    float tiempo_Start = 0.10f;
    float tiemppo_End = 0.20f;

    //
    ParticleSystem collectablePart;

    public Canvas canvas;

    private void Awake()
    {
        //textoPortada.fontSize = 20;
    }

    void Start()
    {
        
        collectablePart = GameObject.Find("CollectableParticles").GetComponent<ParticleSystem>();
        audioPickUp = GetComponentInParent<AudioSource>();
         canvas = canvas.GetComponent<Canvas>();
        canvas.enabled = !canvas.enabled;

    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {

            //Audio de el collectable
            canvas.enabled = true;
            audioPickUp.Play();
            textoPortada.fontSize = 14;
            //Cambiar cada exploción de cada particula
            collectablePart.transform.position = transform.position;
            collectablePart.Play();//Activa el sonido
            Destroy(gameObject);
            Destroy(CollectableItem);
            CollectableQuantity += 10;
            CollectableTex.text = CollectableQuantity.ToString();
            //UpdateScoreLable(scorePlayer, CollectableQuantity);

            if (CollectableQuantity == 50)
            {
                CollectableQuantity = 0;
                tiempo_Start += Time.deltaTime;
               // if (tiempo_Start >= tiemppo_End)
                //{
                    SceneManager.LoadScene("WinSceneLevel1");
               // }
                
            }
            
        }
        
    }
}
