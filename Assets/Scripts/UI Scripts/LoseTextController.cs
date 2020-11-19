using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseTextController : MonoBehaviour {

    private Text text;
    TimerController timer;
    LoseTracker loseTracker;
    WinTracker winTracker;

    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();
        timer = FindObjectOfType<TimerController>();
        loseTracker = FindObjectOfType<LoseTracker>();
        winTracker = FindObjectOfType<WinTracker>();
    }

    // Update is called once per frame
    void Update()
    {
        if (loseTracker.lose == true && winTracker.win != true){
            text.text = "You lose!\nTime: " + timer.time;
        }
    }

}
