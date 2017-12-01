using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
	public Text timerText;
	public int time;
	public float seconds, minutes;
	public Text endText;

	// Use this for initialization
	void Start () {
		timerText = GetComponent<Text>() as Text;
		endText = GetComponent<Text>() as Text;
	}
	
	// Update is called once per frame
	void Update () {
		minutes = (int)(Time.time / 60f);
		seconds = (int)(Time.time % 60f);
		timerText.text = minutes.ToString ("00") + ":" + seconds.ToString ("00");
		
	}

	void LateUpdate(){
		if (minutes >= 1) {
			endText.text = "Time is Up!!";
			SceneManager.LoadScene("game_01");
			minutes = 0;
			seconds = 0;
		}

	}
}
