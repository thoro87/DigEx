using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAssignment : MonoBehaviour {

    public Transform TopRow;

    private int Mode = 1;
    private float Interval;
    private float Timer;
    private Camera[] CamerasTopRow;
    private Camera[] CamerasAll;
    private Camera[] CurrentCameras;
    private int CurrentIndex;

	void Start () {
        CamerasTopRow = TopRow.GetComponentsInChildren<Camera>();
        CamerasAll = GetComponentsInChildren<Camera>();
        CurrentCameras = CamerasAll;
        SetMode(Mode);
	}
	
	void Update () {
        Timer += Time.deltaTime;
        if (Timer >= Interval) {
            Timer = 0f;

            CurrentCameras[CurrentIndex].enabled = false;

            if (Mode == 1) {
                // 1: Random all
                CurrentIndex = Random.Range(0, CamerasAll.Length);
            } else if (Mode == 2) {
                // 2: TopRow Circle
                CurrentIndex++;
                if (CurrentIndex == CamerasTopRow.Length) {
                    CurrentIndex = 0;
                }
            }
            CurrentCameras[CurrentIndex].enabled = true;
        }
	}

    public void SetMode(int newMode) {
        CurrentCameras[CurrentIndex].enabled = false;

        Mode = newMode;
        Timer = 0f;
        if (newMode == 1) {
            // 1: Random all
            Interval = 1f;
            CurrentIndex = Random.Range(0, CamerasAll.Length);
            CurrentCameras = CamerasAll;
        } else if (newMode == 2) {
            // 2: TopRow cirlce
            Interval = 0.05f;
            CurrentIndex = 0;
            CurrentCameras = CamerasTopRow;
        }
        CurrentCameras[CurrentIndex].enabled = true;
    }
}
