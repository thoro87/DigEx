using UnityEngine;
using System.Collections;

public class Lerp : MonoBehaviour {

	private Vector3 Target;
	private float Speed = 2f;
	private float Frac = 0f;

	public void Start () {
		Target = transform.position + new Vector3 (0, 0, -0.8f);
	}

	void Update () {
		if (Frac < 1f) {
			Frac += Time.deltaTime * Speed;
			transform.position = Vector3.Lerp(transform.position, Target, Frac);
		}
	}
}
