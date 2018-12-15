using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		// gameObject.transform.LookAt(Camera.main.transform);
		gameObject.GetComponent<Rigidbody>().velocity = Vector3.back * speed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
