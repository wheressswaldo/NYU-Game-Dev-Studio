﻿using UnityEngine;
using System.Collections;

public class Reset : MonoBehaviour {
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.R)) {
			Application.LoadLevel(0);
			Pathmaker.counter = 0;
			TilePositions.tilePositions.Clear();
		}
	}
}
