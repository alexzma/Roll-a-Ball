using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetTracker : MonoBehaviour {

    public void Reset()
    {
        OverallTracker overallTracker = FindObjectOfType<OverallTracker>();
        overallTracker.Lose();
    }

}
