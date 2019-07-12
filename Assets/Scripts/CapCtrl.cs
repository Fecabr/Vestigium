using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapCtrl : MonoBehaviour {


    public List<Animator> listanimationsbtns;
    public GameObject Joystick;
    public GameObject canvasObject;
    bool clickcap;
	// Use this for initialization
	void Start () {
        clickcap = false;
	}
	
	// Update is called once per frame
	void Update () {

        //De esta forma puedo saber a que objeto le da click en el ambiente 3d
        //if (Input.GetMouseButtonUp(0) | Input.GetMouseButtonUp(1))
        //{
        //    RaycastHit hit;
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    Debug.DrawRay(ray.origin, ray.direction * 10, Color.yellow);
        //    if (Physics.Raycast(ray, out hit))
        //    {
        //        BoxCollider bc = hit.collider as BoxCollider;
        //        if (bc != null)
        //        {
        //            switch (bc.gameObject.name)
        //            {
        //                case "cap1":
        //                    if (!clickcap)
        //                    {
        //                        clickcap = true;
        //                        listanimationsbtns[0].SetBool("onclick", true);
        //                        canvasObject.SetActive(true);
        //                        Joystick.SetActive(false);
        //                    }
        //                    //iniciar cap 1
        //                    break;
        //                case "cap2":
        //                    if (!clickcap)
        //                    {
        //                        clickcap = true;
        //                        listanimationsbtns[1].SetBool("onclick", true);
        //                        canvasObject.SetActive(true);
        //                        Joystick.SetActive(false);
        //                    }                            
        //                    //iniciar cap 2
        //                    break;
        //                case "cap3":
        //                    if (!clickcap)
        //                    {
        //                        clickcap = true;
        //                        listanimationsbtns[2].SetBool("onclick", true);
        //                        canvasObject.SetActive(true);
        //                        Joystick.SetActive(false);
        //                    }                            
        //                    //iniciar cap 3
        //                    break;
        //                case "cap4":
        //                    if (!clickcap)
        //                    {
        //                        clickcap = true;
        //                        listanimationsbtns[3].SetBool("onclick", true);
        //                        canvasObject.SetActive(true);
        //                        Joystick.SetActive(false);
        //                    }                            
        //                    //iniciar cap 4
        //                    break;
        //            }
        //        }
        //    }
        //}
    }

    public void Backcap()
    {
        clickcap = false;
        canvasObject.SetActive(false);
        Joystick.SetActive(true);
    }
}
