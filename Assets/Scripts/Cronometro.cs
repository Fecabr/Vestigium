using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cronometro : MonoBehaviour {

    // Use this for initialization
    bool timerStarted;
    public Text textoTimer;
    public float currenttime;
    public GameObject logo;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timerStarted)
        {
            currenttime -= Time.deltaTime;
            textoTimer.text = writetime(currenttime);
        }
    }

    private string writetime(float time)
    {
        int minutos = Convert.ToInt32((time / 60));
        if (currenttime < 60)
            minutos = 0;
        if (currenttime > 60)
            minutos = 1;
        if (currenttime < 0f)
            return "00:00";
        int segundos = Convert.ToInt32((time % 60));
        //float milisegundos = (time * 100) % 100;
        return minutos.ToString("00") + ":" + segundos.ToString("00"); /*+ ":" + milisegundos.ToString("00");*/
    }


    public void StartTimer()
    {
        logo.SetActive(true);
        textoTimer.gameObject.SetActive(true);
        timerStarted = true;
    }

    public void StopTimer()
    {
        logo.SetActive(false);
        textoTimer.gameObject.SetActive(false);
        timerStarted = false;
    }
}
