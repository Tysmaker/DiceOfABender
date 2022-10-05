using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    //public GameState state;

    /*public static event Action<GameState> OnGameStateChanged;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {

    }

    public void UpdateGameState(GameState newState)
    {
        state = newState;

        switch (newState)
        {
            case GameState.Dialogue;
                break;
            case GameState.PlayerTurn:
                break;
            case GameState.Enemyturn:
                break;
            case GameState.Victory:
                break;
            case GameState.Lose:
                break;


                default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }

        OnGameStateChanged?.invoke(newState);
    }






    public enum GameState
    {

        PlayerTurn,
        EnemyTurn,
        Victory,
        Lose
    }





    */

}
