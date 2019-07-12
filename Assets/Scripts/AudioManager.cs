using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {
    public AudioClip[] sonidos;
    private GameObject[] objetosPorSonido;
    private AudioSource[] reproductores;   
          
	// Use this for initialization
	void Start () {
        objetosPorSonido = new GameObject[sonidos.Length];
        reproductores = new AudioSource[sonidos.Length];
        for (int i = 0; i < sonidos.Length; ++i) {
            objetosPorSonido[i] = new GameObject();
            objetosPorSonido[i].transform.parent = this.transform;
            objetosPorSonido[i].name = sonidos[i].name + "_GO";
            reproductores[i] = objetosPorSonido[i].AddComponent<AudioSource>();
            reproductores[i].clip = sonidos[i];
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ReproducirSonido(int index, float minPitch, float maxPitch) {       
        reproductores[index].pitch = Random.Range(minPitch,maxPitch);
        reproductores[index].Play();       
    }

    public void DetenerSonido(int index)
    {
        reproductores[index].Stop();
    }
}
