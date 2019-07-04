using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;

    public int points =0;
    private int itemAmnt = 0;
    private int PlayerLifes = 3;
  

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void PickItems()
    {
        points += 10;
        itemAmnt++;
        // GUI.Label(new Rect(Screen.width / 2, 10, 100, 100), "Puntación"+points);
        //Debug.Log("La puntación actual es " + points);
        // OnGUI();
       
        if (points == 50)
        {
            Debug.Log("Ganaste el juego");
        }
       
    }

 
    //public void OnGUI()
    //{
    //    GUI.Label(new Rect(Screen.width / 2, 10, 100, 100), "La puntación es " + points);
    //}

    public void LoseLife()
    {
        if (PlayerLifes > 1)
        {
            PlayerLifes--;
        }
        else
        {
            PlayerLifes = 0;
            //Mostrar Pantalle de Gameover
            Debug.Log("Moriste");
            Destroy(gameObject);
      
        }
    }
}
