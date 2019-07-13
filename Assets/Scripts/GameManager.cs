using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum GameState{
    menu,
    inGame,
    gameOver
 }
public class GameManager : MonoBehaviour {

    public static GameManager instance = null;
    //Inicializamos en muenu
    public GameState currentGameState = GameState.menu;
    
    public int points = 0;
    private int itemAmnt = 0;
    private int PlayerLifes = 3;

 
    //private void Awake()
    //{
    //    if (instance == null)
    //    {
    //        instance = this;
    //    }
    //    else if (instance != this)
    //    {
    //        Destroy(gameObject);
    //    }
    //}

    //Necesario para saber en que esta el juego, vamos a guardar el estado.
    public void StartGame()
    {

    }

    public void GameOver()
    {

    }

    public void BackToMenue()
    {

    }

    //Modificar el estado del juego entre estados, 
    private void setGameState(GameState newGameState)
    {
        if (newGameState == GameState.menu)
        {
            //TODO: Colocar la logica del menu
        }
        else if(newGameState==GameState.inGame)
        {
            //TODO: hay que preparar la esecena para jugar
        }
        else if (newGameState == GameState.gameOver)
        {
            //TODO: Prepar el juego para el gameOver
        }
        //Utulizamos este metodo como un semaforo.
        this.currentGameState = newGameState;
    }

    public void PickItems()
    {
        points += 10;
        itemAmnt++;       
        if (points == 50)
        {
            Debug.Log("Ganaste el juego");
        }
       
    }


}
