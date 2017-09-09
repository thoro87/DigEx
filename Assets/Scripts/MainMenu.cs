using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	void Start() {
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
	}

	public void LoadScene(string sceneName) {
		SceneManager.LoadScene(sceneName);
	}

	public void Quit() {
		Application.Quit ();
	}
}
