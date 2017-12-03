using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedCameraRotate : MonoBehaviour {

    public Transform Swivel;
    public Light Light;
    public int Left = -75;
    public int Right = 75;
    public float Speed = 30;
    public float PauseForSeconds = 2f;

    private int Target;
    private float PauseFor;
    private float IgnoreSwitchFor;

    private float LightInterval = 2f;
    private float LightOnTime = 0.2f;
    private float LightTimer;

    void Start() {
        Target = Random.Range(0, 1f) > 0.5f ? Left : Right;
        LightTimer = Random.Range(0, LightInterval);
    }

    void Update () {
        // rotation
        if (PauseFor > 0) {
            PauseFor -= Time.deltaTime;
        } else {
            Swivel.Rotate(Vector3.up, Speed * Time.deltaTime * (Target == Right ? 1 : -1));
            if (IgnoreSwitchFor > 0) {
                IgnoreSwitchFor -= Time.deltaTime;
            } else {
                CheckSwitchDirection();
            }
        }

        // light
        if (Light.intensity > 0) {
            LightTimer -= Time.deltaTime;
            if (LightTimer < 0) {
                Light.intensity = 0;
                LightTimer = LightInterval;
            }
        } else {
            if (LightTimer < 0) {
                Light.intensity = 1.7f;
                LightTimer = LightOnTime;
            } else {
                LightTimer -= Time.deltaTime;
            }
        }
    }

    private void CheckSwitchDirection() {
        float angle = Swivel.localEulerAngles.y;
        angle = (angle > 180) ? angle - 360 : angle;
        if (angle > Right) {
            Target = Left;
            PauseFor = PauseForSeconds;
            IgnoreSwitchFor = 0.5f;
        } else if (angle < Left) {
            Target = Right;
            PauseFor = PauseForSeconds;
            IgnoreSwitchFor = 0.5f;
        }
    }
}
