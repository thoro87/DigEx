using UnityEngine;
using System.Collections;

public class Screen : MonoBehaviour {

    //WebGLMovieTexture tex;
    //bool videoRunning;

    void Start() {
        ((MovieTexture)GetComponent<Renderer>().material.mainTexture).Play();

        //tex = new WebGLMovieTexture("StreamingAssets/The Roaring 1920s.mp4");
        //GetComponent<MeshRenderer>().material.mainTexture = tex;
    }

    void Update() {

        //if (tex.isReady && !videoRunning) {
        //    tex.Play();
        //    tex.loop = true;
        //    videoRunning = true;
        //}
        //tex.Update();
    }
}
