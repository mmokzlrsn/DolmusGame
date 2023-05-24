using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class GameStateManager : MonoBehaviour
{
    public static GameStateManager instance;
     
    public GameStateEnums CurrentState { get; private set; }


    private void Awake()
    {
        instance = this;
    }

    public void SetGameStateToDriving()
    {
        CurrentState= GameStateEnums.Driving;

    }

    public void SetGameStateToBoarding()
    {
        CurrentState= GameStateEnums.Boarding;
    }

    public void SetGameStateToWaiting()
    {
        CurrentState= GameStateEnums.Waiting;
    }


}

public enum GameStateEnums
{
    Driving, Boarding, Waiting
}
