using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTextController : MonoBehaviour {

    WinTracker winTracker;
    private Text text;
    TimerController timer;

	// Use this for initialization
	void Start () {
        winTracker = FindObjectOfType<WinTracker>();
        text = GetComponent<Text>();
        timer = FindObjectOfType<TimerController>();
	}
	
	// Update is called once per frame
	void Update () {
        if (winTracker.win == true){
            text.text = "You won!\nTime: " + timer.time;
        }
	}
}
