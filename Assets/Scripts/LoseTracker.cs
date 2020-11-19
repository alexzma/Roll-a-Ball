using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseTracker : MonoBehaviour {

    public bool lose = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && FindObjectOfType<WinTracker>().win != true){
            lose = true;
            OverallTracker overallTracker = FindObjectOfType<OverallTracker>();
            overallTracker.Lose();
        }
    }

}
