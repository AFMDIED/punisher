using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionExplo : MonoBehaviour {
		private float pow = 6.0f;
		private float radius = 2.0f;
		// Use this for initialization
		void Start () {
		}

		// Update is called once per frame
		void Update () {

		}

		void OnCollisionEnter(Collision c){
			Vector3 positionOfExplosion = transform.position;
			c.rigidbody.AddExplosionForce(pow, positionOfExplosion, radius, 5.0f,ForceMode.Impulse);

		}
	}