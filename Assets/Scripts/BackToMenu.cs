﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering;

public class BackToMenu : MonoBehaviour {
	void Update() {
		if (Input.GetKeyDown(KeyCode.Escape)) {
			SceneManager.LoadScene ("menu");
		}
	}
}
