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
		if (Input.GetKeyDown("r") || Input.Getkey("r")){
		
			Vector3 rotation = new Vector (0.0f, 3.0f, 0.0)
			transform.RotateAround(ball.transform.position, Vector3.up, Time.deltaTime * 20);
			this.UpdateDiff();	
		} else if(Input.GetKeyDow("t") || Input.GetKey("t")){
			transform.RotateAround(ball.transform.position, Vector3.down, Time.deltaTime * 20);
			this.UpdateDiff();	
	}
	
	void UpdateDiff(){
			
    }
}
