using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonCtrl : MonoBehaviour
{


    public enum ButtonType
    {
        Capitulo1,
        Capitulo2,
        Capitulo3,
        Capitulo4,
        testfinal
    }
    private GameObject joystick;
    public ButtonType buttonType;
    //public GameObject loading;

    // Use this for initialization
    void Start()
    {
        joystick = GameObject.Find("MobileSingleStickControl");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PressButton()
    {
        //gameObject.GetComponent<Animator>().SetBool("onclick", true);
        StartCoroutine(Press());
    }

    IEnumerator Press()
    {
        yield return new WaitForSeconds(0.5f);
        int indexcap = PlayerPrefs.GetInt("module1");
        switch (buttonType)
        {
            case ButtonType.Capitulo1:
                joystick.SetActive(false);
                StartCoroutine(loadlevelasyn("Capitulo1"));
                break;
            case ButtonType.Capitulo2:
                if(indexcap >= 1)
                {
                    joystick.SetActive(false);
                    StartCoroutine(loadlevelasyn("Capitulo2"));
                }
                break;
            case ButtonType.Capitulo3:
                if (indexcap >= 2)
                {
                    StartCoroutine(loadlevelasyn("Capitulo3"));
                }
                break;
            case ButtonType.Capitulo4:
                if (indexcap >= 3)
                {
                    joystick.SetActive(false);
                    StartCoroutine(loadlevelasyn("Capitulo4"));
                }
                break;
            case ButtonType.testfinal:
                if (indexcap >= 4)
                {
                    joystick.SetActive(false);
                    StartCoroutine(loadlevelasyn("ActividadFinal"));
                }
                break;
        }
    }

    IEnumerator loadlevelasyn(string secene)
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(secene);

        while (!asyncOperation.isDone)
            yield return asyncOperation;
    }
}
