using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ballcontrollet : MonoBehaviour {

	public float speed;
	public Text countText;

	private Rigidbody rb;
	private int numMaxSaltos;
	private int counter;
	private int count;

	// Use this for initialization
	void Start () {
		this.counter = 0;
		this.rb = GetComponent<Rigidbody>();
		numMaxSaltos = 2;
		count = 0;
		SetCountText ();

	}


	void FixedUpdate () {
		float horizontalAxis = Input.GetAxis("Horizontal");
		float verticalAxis = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3(horizontalAxis, 0.0f,verticalAxis);
		rb.AddForce(movement*speed);

		if(Input.GetKeyDown("space")&& numMaxSaltos > 0){
			Vector3 jumpForce = new Vector3(0.0f, 3.0f, 0.0f);
			rb.AddForce(jumpForce, ForceMode.Impulse);
			numMaxSaltos--;
		}
	}

	void OnCollisionEnter(Collision c){
		this.numMaxSaltos = 100;
		if (c.gameObject.tag == "pickable") {
			counter++;
			c.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
		}
	}

		void SetCountText ()
		{ 
			countText.text = "Coins: " + count.ToString ();
		}
   }

