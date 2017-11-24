using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mirarhacia : MonoBehaviour {
	public Transform Target;

	void Updata()
	{
		transform.LookAt (Target);
	}
}
