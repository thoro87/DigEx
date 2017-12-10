using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeController : MonoBehaviour {

    public Transform PlayerTransform;

    public float Z_1;
    public float Z_0;

    private AudioSource AudioSource;

	void Start () {
        AudioSource = GetComponent<AudioSource>();
	}
	
	void Update () {
        float vol;
        if (PlayerTransform.position.z < Z_1) {
            vol = 1;
        } else if (PlayerTransform.position.z > Z_0) {
            vol = 0;
        } else {
            float dist = PlayerTransform.position.z - Z_1;

            vol = 1 - (dist / (Z_0 - Z_1));
        }
        AudioSource.volume = vol;
	}
}
