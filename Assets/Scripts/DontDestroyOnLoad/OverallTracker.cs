using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OverallTracker : MonoBehaviour {

    WinTracker winTracker;
    LoseTracker loseTracker;
    TimerController timer;
    public float time;
    public float losses;

	// Use this for initialization
	public void Start () {
        time = 0;
        losses = 0;
	}

    public void Win () {
        timer = FindObjectOfType<TimerController>();
        time += timer.time;
    }

    public void Lose () {
        timer = FindObjectOfType<TimerController>();
        time += timer.time;
        losses++;
    }
}
