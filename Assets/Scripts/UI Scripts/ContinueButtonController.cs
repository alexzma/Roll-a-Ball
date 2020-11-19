using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContinueButtonController : MonoBehaviour {

    WinTracker winTracker;
    Image image;
    Button button;

	// Use this for initialization
	void Start () {
        winTracker = FindObjectOfType<WinTracker>();
        image = GetComponent<Image>();
        button = GetComponent<Button>();
	}
	
	// Update is called once per frame
	void Update () {
        if (winTracker.win == true){
            image.enabled = true;
            button.interactable = true;
        }
	}
}
