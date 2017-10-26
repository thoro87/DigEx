using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering;

public class IngameMenu : MonoBehaviour {

    public GameObject Group_Surveillance;

    private Scene CurrentScene;

    void Start() {
        CurrentScene = SceneManager.GetActiveScene();
        Group_Surveillance.SetActive(CurrentScene.name == "surveillance");
    }

    void Update() {

        if (CurrentScene.name == "surveillance") {
            if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1)) {
                GameObject.Find("SimpleCameras").GetComponent<CameraAssignment>().SetMode(1);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2)) {
                GameObject.Find("SimpleCameras").GetComponent<CameraAssignment>().SetMode(2);
            }
        }

        #if !UNITY_EDITOR
        if (Input.GetKeyDown(KeyCode.Escape)) {
			SceneManager.LoadScene ("menu");
		}
        #endif
    }
}
