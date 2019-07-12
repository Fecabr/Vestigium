using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuCtrl : MonoBehaviour {


    public List<Animator> listanimtor = new List<Animator>();
    public Sprite desbloqueado;
    public Sprite bloqueado;
	// Use this for initialization
	void Start () {

        StartCoroutine(StartButtons());
        initcaps();
    }

    public void initcaps()
    {
        int indexcap = PlayerPrefs.GetInt("module1");
        switch (indexcap)
        {
            case 0:
                listanimtor[0].transform.GetChild(2).GetComponent<Image>().sprite = desbloqueado;
                listanimtor[1].transform.GetChild(2).GetComponent<Image>().sprite = bloqueado;
                listanimtor[2].transform.GetChild(2).GetComponent<Image>().sprite = bloqueado;
                listanimtor[3].transform.GetChild(2).GetComponent<Image>().sprite = bloqueado;
                listanimtor[4].transform.GetChild(2).GetComponent<Image>().sprite = bloqueado;
                break;
            case 1:
                listanimtor[0].transform.GetChild(2).GetComponent<Image>().sprite = desbloqueado;
                listanimtor[1].transform.GetChild(2).GetComponent<Image>().sprite = desbloqueado;
                listanimtor[2].transform.GetChild(2).GetComponent<Image>().sprite = bloqueado;
                listanimtor[3].transform.GetChild(2).GetComponent<Image>().sprite = bloqueado;
                listanimtor[4].transform.GetChild(2).GetComponent<Image>().sprite = bloqueado;
                break;
            case 2:
                listanimtor[0].transform.GetChild(2).GetComponent<Image>().sprite = desbloqueado;
                listanimtor[1].transform.GetChild(2).GetComponent<Image>().sprite = desbloqueado;
                listanimtor[2].transform.GetChild(2).GetComponent<Image>().sprite = desbloqueado;
                listanimtor[3].transform.GetChild(2).GetComponent<Image>().sprite = bloqueado;
                listanimtor[4].transform.GetChild(2).GetComponent<Image>().sprite = bloqueado;
                break;
            case 3:
                listanimtor[0].transform.GetChild(2).GetComponent<Image>().sprite = desbloqueado;
                listanimtor[1].transform.GetChild(2).GetComponent<Image>().sprite = desbloqueado;
                listanimtor[2].transform.GetChild(2).GetComponent<Image>().sprite = desbloqueado;
                listanimtor[3].transform.GetChild(2).GetComponent<Image>().sprite = desbloqueado;
                listanimtor[4].transform.GetChild(2).GetComponent<Image>().sprite = bloqueado;
                break;
            case 4:
                listanimtor[0].transform.GetChild(2).GetComponent<Image>().sprite = desbloqueado;
                listanimtor[1].transform.GetChild(2).GetComponent<Image>().sprite = desbloqueado;
                listanimtor[2].transform.GetChild(2).GetComponent<Image>().sprite = desbloqueado;
                listanimtor[3].transform.GetChild(2).GetComponent<Image>().sprite = desbloqueado;
                listanimtor[4].transform.GetChild(2).GetComponent<Image>().sprite = desbloqueado;
                break;
        }
    }

    IEnumerator StartButtons()
    {
        foreach(Animator animator in listanimtor)
        {
            yield return StartCoroutine(Showbuttons(animator));
        }
    }
    
    IEnumerator Showbuttons(Animator animator)
    {
        yield return new WaitForSeconds(0.2f);
        animator.SetBool("show", true);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void backinit()
    {
        SceneManager.LoadScene("Init");
    }
}
