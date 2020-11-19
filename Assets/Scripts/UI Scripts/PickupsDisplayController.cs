using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupsDisplayController : MonoBehaviour {

    public int current;
    public int total;
    Text text;

	// Use this for initialization
	void Start () {
        current = 0;
        total = GameObject.FindGameObjectsWithTag("Pickup").Length;
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        text.text = "Pickups: " + current + "/" + total;
	}
}
