using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCtrl1 : MonoBehaviour {


    public enum ActivityCap {VIDEO, RA, PREGUNTAS, jUEGO}

    public ActivityCap activity;
    public CapController1 capcontroller1;
    public CapController2 capcontroller2;
    public CapController3 capcontroller3;
    public CapController4 capcontroller4;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Onclickbutton()
    {

        switch (activity)
        {
            case ActivityCap.jUEGO:
                break;
            case ActivityCap.PREGUNTAS:
                if(capcontroller1 != null)
                    capcontroller1.Showquesions();
                else if(capcontroller2 != null)
                    capcontroller2.Showquesions();
                else if (capcontroller3 != null)
                    capcontroller3.Showquesions();
                else if (capcontroller4 != null)
                    capcontroller4.Showquesions();
                break;
            case ActivityCap.RA:
                break;
            case ActivityCap.VIDEO:
                if (capcontroller1 != null)
                    capcontroller1.Showvideo();
                else if (capcontroller2 != null)
                    capcontroller2.Showvideo();
                else if (capcontroller3 != null)
                    capcontroller3.Showvideo();
                else if (capcontroller4 != null)
                    capcontroller4.Showvideo();
                break;
        }
    }
}
