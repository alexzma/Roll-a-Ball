using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingScript : MonoBehaviour {

    Transform transform;
    float degree;
    public float speed = 5;

	// Use this for initialization
	void Start () {
        transform = GetComponent<Transform>();
        degree = 0;
	}
	
	// Update is called once per frame
	void Update () {
        degree += Time.deltaTime * speed;
        Quaternion rotation = new Quaternion(Mathf.Cos(degree), 0, 1, 0);
        transform.rotation = rotation;
	}
}
