using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour {

    public GameObject CubePrefab;

    public int Width = 30;
    public int Height = 30;
    public int Depth = 30;

	void Start () {
        for (int w = 0; w < Width; w++) {
            for (int h = 0; h < Height; h++) {
                for (int d = 0; d < Depth; d++) {
                    Instantiate(CubePrefab, new Vector3(w, h, d + 10), Quaternion.identity, transform);
                }
            }
        }
	}
	
}
