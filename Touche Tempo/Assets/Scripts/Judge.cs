using System.Data;
using System.Diagnostics;
using UnityEngine;

public class Judge : MonoBehaviour
{
    public State goalState, playerState;
    public int goalBeat;
    public Metronome metronome;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Evaluate()
    {

        if (playerState == goalState && metronome.activeBeat == goalBeat)
        {
            UnityEngine.Debug.Log("Beat Match!!");
        }
        else
        {
            UnityEngine.Debug.Log("Beat Fail!!");
        }
    }

    void UpdateGoals(State state, int beat)
    {
        goalState = state;
        goalBeat = beat;
    }
}