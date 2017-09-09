using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadOnClick : MonoBehaviour {

	void Start() {
		Cursor.visible = true;
	}

	public void LoadScene(string sceneName) {
		SceneManager.LoadScene(sceneName);
	}
}
