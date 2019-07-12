using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CapController1 : MonoBehaviour {


    public Animator videoanimator;
    public Animator questionsanimator;
    //public GameObject test;
    private bool flagpanel;
    private int questionCounter;
    public GameObject joystick;
    public Testcap1Ctrls testcapctrls1;

    public List<Animator> listanimators;

    // Use this for initialization
    void Start() {
        flagpanel = false;
        StartCoroutine(StartButtons());
    }

    IEnumerator StartButtons()
    {
        foreach(Animator animator in listanimators)
        {
            yield return StartCoroutine(ShowButtons(animator));
        }
    }

    IEnumerator ShowButtons(Animator animator)
    {
        yield return new WaitForSeconds(0.2f);
        animator.SetBool("show", true);
    }

    // Update is called once per frame
    void Update() {

    }

    public void Showvideo()
    {
        if (!flagpanel)
        {
            joystick.SetActive(false);
            videoanimator.SetBool("open", true);
            flagpanel = true;
        }
    }

    public void Hidevideo()
    {
        if (flagpanel)
        {
            joystick.SetActive(true);
            videoanimator.SetBool("open", false);
            flagpanel = false;
        }
    }

    public void Showquesions()
    {
        if (!flagpanel)
        {
            joystick.SetActive(false);
            questionsanimator.SetBool("open", true);
            flagpanel = true;
            testcapctrls1.startPanelQuestions();
        }
    }

    public void Hidequesions()
    {
        if (flagpanel)
        {
            testcapctrls1.playtest = false;
            joystick.SetActive(true);
            questionsanimator.SetBool("open", false);
            flagpanel = false;
        }
    }

    public void backMainmodule()
    {
        SceneManager.LoadScene("Menu");
    }
}
