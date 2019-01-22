using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer : MonoBehaviour {
    public GameObject linePrefab;

    DrawingLine currentLine;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void DrawPoint(Vector3 position, Quaternion rotation) {
        StartLine(position, rotation);
        currentLine.DrawPoint(position);
    }

    void StartLine(Vector3 position, Quaternion rotation) {
        if (currentLine != null) return;
        var currentLineObject = GameObject.Instantiate(linePrefab, position, rotation);
        currentLine = currentLineObject.GetComponent<DrawingLine>();
        if (currentLine == null) {
            Debug.LogError("Missconfigured line prefab");
        }
    }

    public void StopDrawing(){
        if (currentLine == null) return;
        currentLine = null;
    }
}
