using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minecraft : MonoBehaviour {

    public Camera Camera;
    public float Distance = 6;

    private int LayerID;

    void Start() {
        LayerID = LayerMask.NameToLayer("MinecraftLayer");
    }

    void Update() {
        RaycastHit hit;
        Ray ray = Camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, Distance, 1 << LayerID)) {
            GameObject objectHit = hit.transform.gameObject;
            Destroy(objectHit);
        }
    }
}
