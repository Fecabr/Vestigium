using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Item : MonoBehaviour
{

    public Text scorePlayer;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            GameManager.instance.PickItems();
            Destroy(gameObject);
            UpdateScoreLable(scorePlayer,GameManager.instance.points);
        }
    }
    void UpdateScoreLable(Text label,int score)
    {
        label.text = score.ToString();
    }

    //void OnGUI()
    //{
    //    GUI.Label(new Rect(Screen.width / 2, 10, 100, 100), "Botonn");
    //    GUI.Label(new Rect(Screen.width / 2, 10, 100, 100), "La puntación es " + GameManager.instance.points);
    //}
}
