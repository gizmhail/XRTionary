using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using Valve.VR;

[RequireComponent(typeof(Drawer))]
public class PenDrawer : MonoBehaviour {
    public Transform penTip;
    Drawer drawer;

	// Use this for initialization
	void Start () {
        drawer = GetComponent<Drawer>();	
	}
	
	// Update is called once per frame
	void Update () {
        if (SteamVR_Input._default.inActions.InteractUI.GetState(SteamVR_Input_Sources.Any))
        {
            drawer.DrawPoint(penTip.position, penTip.rotation);
        }
        else {
            drawer.StopDrawing();
        }
	}
}
