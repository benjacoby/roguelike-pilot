using UnityEngine;
using System.Collections;

public class ScreenDebugger : MonoBehaviour {

	private Vector3 mouseLocationWorldUnits;
	private Vector3 mouseLocation;
	
	void Update () 
	{
		ScreenDimensions ();
	}
	
	void ScreenDimensions()
	{
		mouseLocation = Input.mousePosition;
		mouseLocationWorldUnits = Camera.main.ScreenToWorldPoint (mouseLocation);
		Debug.Log ("Screen Width = " + Screen.width + ", Screen Height = " + Screen.height + ", Mouse coordinates = " + mouseLocation + "pixels & " + mouseLocationWorldUnits + " world units");
	}
}	