using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContinueTextController : MonoBehaviour {

    WinTracker winTracker;
    Text text;

	// Use this for initialization
	void Start () {
        winTracker = FindObjectOfType<WinTracker>();
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        if (winTracker.win == true)
        {
            text.text = "Continue";
        }
	}
}
