using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadMenuController : MonoBehaviour {

    SceneController sc;

	// Use this for initialization
	void Start () {
        sc = FindObjectOfType<SceneController>();
	}
	
	// Update is called once per frame
	void Update () {
        sc.loadScene("Menu");
	}
}
