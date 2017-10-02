using UnityEngine;
using System.Collections;

public class WallBuilder : MonoBehaviour {

	public GameObject SimpleStone;

	private Vector3 NextTarget;
	public float Timer;
	private float SpawnInterval;

	void Start() {
		SpawnInterval = 1;
		NextTarget = transform.position;
	}

	public void SpawnStone() {
		Instantiate (SimpleStone, NextTarget, Quaternion.identity, transform);
	}

	public void SetNextTarget() {
		NextTarget += new Vector3 (0, 0, -0.8f);
	}

	void Update() {
		Timer += Time.deltaTime;
		if (Timer >= SpawnInterval) {
			SpawnStone ();
			SetNextTarget ();
			Timer = 0;
		}
	}

}
