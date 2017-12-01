using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camController : MonoBehaviour {
	public GameObject ball;
	private Vector3 diff;

	// Use this for initialization
	void Start () {
		//diff tiene que tener la diferencia de posiciones entre mi GameObject camara y el GameObject que persigo
		this.diff = transform.position - ball.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = ball.transform.position + this.diff;	

	}
	
}
