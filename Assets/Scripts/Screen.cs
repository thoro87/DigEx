using UnityEngine;
using System.Collections;

public class Screen : MonoBehaviour {

    WebGLMovieTexture tex;
    bool videoRunning;

    void Start() {
        tex = new WebGLMovieTexture("StreamingAssets/The Roaring 1920s.mp4");
        GetComponent<MeshRenderer>().material.mainTexture = tex;
    }

    void Update() {
        if (tex.isReady && !videoRunning) {
            tex.Play();
            tex.loop = true;
            videoRunning = true;
        }
        tex.Update();
    }

    //void OnGUI() {
    //    GUI.enabled = tex.isReady;

    //    GUILayout.BeginHorizontal();
    //    if (GUILayout.Button("Play"))
    //        tex.Play();
    //    if (GUILayout.Button("Pause"))
    //        tex.Pause();
    //    tex.loop = GUILayout.Toggle(tex.loop, "Loop");
    //    GUILayout.EndHorizontal();

    //    var oldT = tex.time;
    //    var newT = GUILayout.HorizontalSlider(tex.time, 0.0f, tex.duration);
    //    if (!Mathf.Approximately(oldT, newT)) {
    //        tex.Seek(newT);
    //    }

    //    GUI.enabled = true;
    //}
}
