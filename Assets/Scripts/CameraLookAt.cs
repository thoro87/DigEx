using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAt : MonoBehaviour {
		
	public Transform Target;

	void Update () {
		transform.LookAt (Target);
	}
}
