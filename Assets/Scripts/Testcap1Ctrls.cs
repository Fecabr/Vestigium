using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Testcap1Ctrls : MonoBehaviour {

    public List<GameObject> ListQuestionsContent;
    public List<string> ListAnswers;
    private int Points;
    private int questionindex;
    public Cronometro cronometro;
    public AudioController audiocontroller;
    public Text textcronometro;
    public GameObject reintentarbtn;
    public Text textofinal;
    public Animator llave;

    //queston 3
    public List<Toggle> listAnswers3;
    public int correctas;
    public bool playtest;

    //final
    public Text textnota;
    public Text texttiempo;

	// Use this for initialization
	void Start () {
        questionindex = 0;
        Points = 0;
        playtest = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (playtest)
        {
            if(cronometro.currenttime <= 0)
            {
                foreach (GameObject content in ListQuestionsContent)
                {
                    //falta poner aviso 
                    if (content.name.Equals("Final"))
                        content.SetActive(true);
                    else
                        content.SetActive(false);
                }
            }
        }
    }

    public void startPanelQuestions()
    {
        questionindex = 0;
        Points = 0;
        playtest = false;
        textcronometro.gameObject.SetActive(false);
        cronometro.StopTimer();
        foreach (GameObject content in ListQuestionsContent)
        {
            if (content.name.Equals("Inicio"))
                content.SetActive(true);
            else
                content.SetActive(false);
        }
    }

    public void InitQuestions()
    {
        cronometro.currenttime = 100;
        cronometro.StartTimer();
        questionindex++;
        ChangeQuestion();
        playtest = true;
    }

    public void ChangeQuestion()
    {
        int i = 0;
        foreach(GameObject questionObject in ListQuestionsContent)
        {
            if (i == questionindex)
                questionObject.SetActive(true);
            else
                questionObject.SetActive(false);
            ++i;
        }
    }

    public void Question1(string answer)
    {

        if (answer.Equals(ListAnswers[0]))
        {
            Points++;
            audiocontroller.PlayAudio(0);
        }
        else
            audiocontroller.PlayAudio(1);
        questionindex++;
        ChangeQuestion();
    }

    public void Question2(string answer)
    {
        if (answer.Equals(ListAnswers[1]))
        {
            Points++;
            audiocontroller.PlayAudio(0);
        }
        else
            audiocontroller.PlayAudio(1);
        questionindex++;
        ChangeQuestion();
    }
    public void Question3()
    {
        for(int i =0; i < listAnswers3.Count; ++i)
        {
            if (listAnswers3[i].GetComponent<Toggle>().isOn)
            {
                switch (i)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        ++correctas;
                        break;
                }
            }
        }
        if(correctas == 4)
        {
            audiocontroller.PlayAudio(0);
            Points++;
        }
        else
            audiocontroller.PlayAudio(1);
        questionindex++;
        ChangeQuestion();
    }

    public void Question4(string answer)
    {
        if (answer.Equals(ListAnswers[2]))
        {
            Points++;
            audiocontroller.PlayAudio(0);
        }
        else
            audiocontroller.PlayAudio(1);
        questionindex++;
        ChangeQuestion();
    }

    public void Question5(string answer)
    {
        if (answer.Equals(ListAnswers[3]))
        {
            Points++;
            audiocontroller.PlayAudio(0);
        }
        else
            audiocontroller.PlayAudio(1);
        questionindex++;
        ChangeQuestion();
        fintest();
    }

    public void fintest()
    {
        int finalpoints = (Points * 100) / 5;
        textnota.text = finalpoints.ToString();
        texttiempo.text = textcronometro.text;
        textcronometro.gameObject.SetActive(false);
        if (finalpoints >= 70)
        {
            PlayerPrefs.SetInt("module1", 1);
            reintentarbtn.SetActive(false);
            textofinal.text = "Felicidades has obtenido la llave del capitulo 1";
            llave.SetBool("open", true);
        }
        else
        {
            reintentarbtn.SetActive(true);
            textofinal.text = "Su resultado tiene que ser igual o superior a 70 para obtener la llave";
        }

    }
}
