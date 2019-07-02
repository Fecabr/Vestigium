using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            GameManager.instance.PickItems();
            Destroy(gameObject); 
        }
    }

    //void OnGUI()
    //{
    //    GUI.Label(new Rect(Screen.width / 2, 10, 100, 100), "Botonn");
    //    GUI.Label(new Rect(Screen.width / 2, 10, 100, 100), "La puntación es " + GameManager.instance.points);
    //}
}
