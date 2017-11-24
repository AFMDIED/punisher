using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class push : MonoBehaviour {

	// Use this for initialization
	public float thrust;
	private Rigidbody rb;

	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter(Collision c){
		Vector3 positionOfCollision = transform.forward;
		rb.AddForce(Vector3.forward * thrust);
    }

} 



	

