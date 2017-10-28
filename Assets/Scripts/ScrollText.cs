using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollText : MonoBehaviour {

    public float Duration = 20f;

    private float Start = 27f;
    private float End = -117f;

    private float Timer;

	void Update () {
        Timer += Time.deltaTime;
        if (Timer > Duration) {
            Timer = 0;
        }
        Vector3 newPos = transform.position;
        newPos.z = Mathf.Lerp(Start, End, Timer / Duration);
        transform.position = newPos;
	}
}
