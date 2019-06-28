using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;

    private int points =0;
    private int itemAmnt = 0;
    private int PlayerLifes;

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

    public void PickItem()
    {
        points += 10;
        itemAmnt++;
        Debug.Log("La puntación actual es " + points);
    }

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
      
        }
    }
}
