﻿using UnityEngine;
using System.Collections;

public class countDownTImer : MonoBehaviour {
	float timeRemaining = 60;
	int score = 100; // player score
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timeRemaining -= Time.deltaTime;
	}

	void OnGUI() {
		if (timeRemaining > 0) {
			GUI.Label (new Rect (150, 50, 150, 100), "" + (int) timeRemaining);
		} else {
			if(score >= 100) { // if player score is over 100pts.  we can change the score player has to reach later
				GUI.Label (new Rect (250, 300, 150, 100), "YOU WIN!");
			} else {
				GUI.Label (new Rect (250, 300, 150, 100), "GAME OVER!");
			}
		}
	}
}