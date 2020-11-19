using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalWinTextController : MonoBehaviour {

    OverallTracker overallTracker;
    Text text;

	// Use this for initialization
	void Start () {
        overallTracker = FindObjectOfType<OverallTracker>();
        text = GetComponent<Text>();
        text.text = "Congratulations!\nYou have completed all the levels!\nYou took only " + overallTracker.time +
            " seconds and only lost " + overallTracker.losses + " times!";
	}

}
