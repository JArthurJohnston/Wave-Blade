using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetGenerator : MonoBehaviour {

	private float timeSinceLastSpawn;

	public float spawnGap;

	public GameObject targetTemplate;

	void Start () {
		timeSinceLastSpawn = 0;
	}
	
	void Update () {
		if(timeSinceLastSpawn >= spawnGap){
			timeSinceLastSpawn = 0;
			Instantiate(targetTemplate, gameObject.transform.position, gameObject.transform.rotation);
		} else {
			timeSinceLastSpawn += Time.deltaTime;
		}
	}
}
