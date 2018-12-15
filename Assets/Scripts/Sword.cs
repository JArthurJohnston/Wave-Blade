using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour {

	void OnTriggerEnter(Collider collider){
		if(collider.gameObject.tag == "Target"){
			Destroy(collider.gameObject);
		}

	}
}
