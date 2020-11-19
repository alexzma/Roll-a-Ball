using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour {

    WinTracker winTracker;
    LoseTracker loseTracker;
    Text text;
    public float time;

	// Use this for initialization
	void Start () {
        winTracker = FindObjectOfType<WinTracker>();
        loseTracker = FindObjectOfType<LoseTracker>();
        text = GetComponent<Text>();
        time = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (winTracker.win == false && loseTracker.lose == false)
        {
            time += Time.deltaTime;
            text.text = "Time: " + time;
        }
	}
}
