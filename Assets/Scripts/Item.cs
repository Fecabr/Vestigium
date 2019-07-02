using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject); 
        }
    }

    void OnGUI()
    {
        // GUI.Label(new Rect(Screen.width/2,10,100,100),"Botonn");
        GUI.Label(new Rect(Screen.width / 2, 10, 100, 100), "Nota :El titulo de la portada va en formato Times New Roman tamaño 12");
    }
}
