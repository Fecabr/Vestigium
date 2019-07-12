using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TestFinalCtrl : MonoBehaviour {

    public List<GameObject> listpanelstest;
    public List<Toggle> preguntaslistcheckboxs;
    public List<Toggle> hipotesislistcheckboxs;
    public List<Toggle> experimentolistcheckboxs;
    public List<Toggle> analisislistcheckboxs;
    public GameObject inicio;
    private int indexpanels;
    public AudioController audiocontroller;
    public GameObject mensajeincorrecta;
	// Use this for initialization
	void Start () {
        indexpanels = 0;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void BackMenu()
    {
        SceneManager.LoadScene("Menu"); 
    }

    public void nextpanel()
    {
        for(int i =0; i < listpanelstest.Count; ++i)
        {
            if (i == indexpanels)
                listpanelstest[i].SetActive(true);
            else
                listpanelstest[i].SetActive(false);     
        }
        indexpanels++;
    }

    public void cargarobservacion()
    {
        inicio.SetActive(false);
        nextpanel();
        audiocontroller.PlayAudio(0);
    }


    public void cargarpregunta()
    {
        nextpanel();
        audiocontroller.PlayAudio(0);
    }

    public void cargarhipotesis()
    {
        if (preguntaslistcheckboxs[2].isOn)
        {
            nextpanel();
            audiocontroller.PlayAudio(0);
            mensajeincorrecta.SetActive(false);
        }
        else
        {
            audiocontroller.PlayAudio(1);
            mensajeincorrecta.SetActive(true);
        }
    }

    public void cargarexperimento()
    {
        if (hipotesislistcheckboxs[1].isOn)
        {
            nextpanel();
            audiocontroller.PlayAudio(0);
            mensajeincorrecta.SetActive(false);
        }
        else
        {
            audiocontroller.PlayAudio(1);
            mensajeincorrecta.SetActive(true);
        }
    }

    public void cargaranalisis()
    {
        if (experimentolistcheckboxs[0].isOn)
        {
            nextpanel();
            audiocontroller.PlayAudio(0);
            mensajeincorrecta.SetActive(false);
        }
        else
        {
            audiocontroller.PlayAudio(1);
            mensajeincorrecta.SetActive(true);
        }
    }

    public void cargarconclusion()
    {
        if (analisislistcheckboxs[2].isOn)
        {
            nextpanel();
            audiocontroller.PlayAudio(0);
            mensajeincorrecta.SetActive(false);
        }
        else
        {
            audiocontroller.PlayAudio(1);
            mensajeincorrecta.SetActive(true);
        }
    }

    public void finalizar()
    {
        audiocontroller.PlayAudio(0);
        SceneManager.LoadScene("Menu");
    }
}
