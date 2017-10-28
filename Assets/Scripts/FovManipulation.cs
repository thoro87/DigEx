using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FovManipulation : MonoBehaviour {

    private Camera Camera;
    private Transform PlayerTrans;

	void Start () {
        Camera = GameObject.Find("FirstPersonCharacter").GetComponent<Camera>();
        PlayerTrans = GameObject.Find("Player").transform;
	}
	
	void Update () {
        float t = PlayerTrans.position.z / 30f;
        float newFov = Mathf.Lerp(30, 100f, t);
        Camera.fieldOfView = newFov;
	}
}
