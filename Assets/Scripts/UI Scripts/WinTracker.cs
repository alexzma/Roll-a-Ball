using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTracker : MonoBehaviour {

    public bool win;

	// Use this for initialization
	void Start () {
        win = false;
	}
	
	// Update is called once per frame
	void Update () {
        PickupsDisplayController pickupsDisplayController = FindObjectOfType<PickupsDisplayController>();
        if (pickupsDisplayController.total == pickupsDisplayController.current){
            if (win != true)
            {
                OverallTracker overallTracker = FindObjectOfType<OverallTracker>();
                overallTracker.Win();
                win = true;
            }
        }
	}
}
