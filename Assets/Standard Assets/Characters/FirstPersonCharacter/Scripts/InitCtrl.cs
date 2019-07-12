using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitCtrl : MonoBehaviour {


    public GameObject PanelSocialNetwork;
    public GameObject PanelModules;
    public GameObject PanelbtnsInit;
    public int module;
	// Use this for initialization
	void Start () {
        initSocialNetworks();
        module = 0;
    }


	
	// Update is called once per frame
	void Update () {
		
	}

    private void initSocialNetworks()
    {
        StartCoroutine(loadsocialnetworks());
    }

    IEnumerator loadsocialnetworks()
    {
        yield return new WaitForSeconds(5);
        PanelSocialNetwork.SetActive(true);
    }

    public void Onclickmodule(int index)
    {
        PanelModules.SetActive(false);
        PanelbtnsInit.SetActive(true);
        int capinit = returnindexcapmodule(index);
        module = index;
        if (capinit != 0)
        {
            PanelbtnsInit.transform.GetChild(0).gameObject.SetActive(true);
            PanelbtnsInit.transform.GetChild(1).gameObject.SetActive(true);
            PanelbtnsInit.transform.GetChild(2).gameObject.SetActive(false);
        }
        else
        {
            PanelbtnsInit.transform.GetChild(0).gameObject.SetActive(false);
            PanelbtnsInit.transform.GetChild(1).gameObject.SetActive(false);
            PanelbtnsInit.transform.GetChild(2).gameObject.SetActive(true);
        }
    }

    public int returnindexcapmodule(int index)
    {
        int moduleactive = 0;

        switch (index)
        {
            case 0:
                moduleactive = PlayerPrefs.GetInt("module1");
                break;
            case 1:
                moduleactive = PlayerPrefs.GetInt("module2");
                break;
            case 2:
                moduleactive = PlayerPrefs.GetInt("module3");
                break;
            case 3:
                moduleactive = PlayerPrefs.GetInt("module4");
                break;
            case 4:
                moduleactive = PlayerPrefs.GetInt("module5");
                break;
        }
        return moduleactive;
    }

    public void initModule()
    {
        switch (module)
        {
            case 0:
                SceneManager.LoadScene("Menu");
                break;
            case 1:
                //aqui se pone la scene del modulo 2
                break;
            case 2:
                //aqui se pone la scene del module 3
                break;
            case 3:
                //aqui se pone la scene del module 4
                break;
            case 4:
                //aqui se pone la scene del module 5
                break;
        }
    }

    public void backbtn()
    {
        PanelModules.SetActive(true);
        PanelbtnsInit.SetActive(false);
    }

    public void initnewGame()
    {
        PlayerPrefs.SetInt("capinit", 0);
        switch (module)
        {
            case 0:
                PlayerPrefs.SetInt("module1", 0);
                SceneManager.LoadScene("MainScene");
                break;
            case 1:
                //aqui se pone la scene del modulo 2
                break;
            case 2:
                //aqui se pone la scene del module 3
                break;
            case 3:
                //aqui se pone la scene del module 4
                break;
            case 4:
                //aqui se pone la scene del module 5
                break;
        }
    }

    public void goAR()
    {
        SceneManager.LoadScene("RA");
    }
}
