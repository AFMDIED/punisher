using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour {

	public GameObject obj;
	private Rigidbody rb;
	private Rigidbody rbAjeno;

	// Use this for initialization
	void Start () {
		this.rb = GetComponent<Rigidbody> ();

		rbAjeno = obj.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void LateUpdate () {
		Vector3 offset = rbAjeno.transform.position - transform.position;
		rb.AddForce (offset/60, ForceMode.Impulse);
		//Vector3 impulse = new Vector3 (20.0f, 0.0f, 20.0f);
		//rb.AddForce (impulse, ForceMode.Impulse);
		
	}

	void OnCollisionExit(Collision c){
		if (c.gameObject.tag == "floor"){
			c.gameObject.SetActive (false);
		}
   }
}
