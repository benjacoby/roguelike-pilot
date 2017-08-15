using UnityEngine;
using System.Collections;

public class CameraManager : MonoBehaviour {

	private int boardWidth;
	private int boardHeight;

	void Start () 
	{
		boardWidth = BoardManager.instance.boardWidth;
		boardHeight = BoardManager.instance.boardHeight;
	}

	void SetCameraSize()
	{
		transform.position = new Vector3 (boardWidth / 2f, boardHeight / 2f, -10);
		GetComponent<Camera> ().orthographicSize = boardHeight / 2;
	}

	void SetScreenSize ()
	{
		Screen.SetResolution (boardWidth * 20, boardHeight * 20, false);
	}
}
