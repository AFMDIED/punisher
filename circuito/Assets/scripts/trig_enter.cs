using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trig_enter : MonoBehaviour {
	public GameObject ball;

	// Use this for initialization
	void OnTriggerEnter(Collider other) {
		Destroy (ball);
	}


}
