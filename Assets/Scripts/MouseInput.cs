using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInput : MonoBehaviour {
    public Drawer drawer;
    public Camera drawingCamera;
	// Use this for initialization
	void Start () {
        if (drawer == null) {
            Debug.LogError("Missing drawer");
            gameObject.SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            var screenPoint = Input.mousePosition;
            screenPoint.z = drawingCamera.nearClipPlane;
            var newPoint = drawingCamera.ScreenToWorldPoint(screenPoint);

            //var p = GameObject.CreatePrimitive(PrimitiveType.Cube);
            //p.transform.position = newPoint;
            drawer.DrawPoint(newPoint, Quaternion.LookRotation(drawingCamera.transform.forward));
        }
        else {
            drawer.StopDrawing();
        }
	}
}
