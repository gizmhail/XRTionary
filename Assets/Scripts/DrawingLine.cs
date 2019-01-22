using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class DrawingLine : MonoBehaviour
{
    LineRenderer lineRenderer;
    List<Vector3> points = new List<Vector3>();
    // Use this for initialization
    void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DrawPoint(Vector3 worldPosition)
    {
        Debug.Log("Drawing world position:" + worldPosition);
        Vector3 position = transform.InverseTransformPoint(worldPosition);
        points.Add(position);
        lineRenderer.positionCount = points.Count;
        lineRenderer.SetPositions(points.ToArray());
    }
}
