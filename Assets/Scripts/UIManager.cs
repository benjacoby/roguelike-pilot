using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		SetupUI ();
	}

	void SetupUI()
	{
		char[,] board = BoardManager.instance.BOARD;
		print (board.GetLength(0));
		print (board.GetLength(1));

		for (int xi = 0; xi < board.GetLength (0); xi++) {
			for (int yi = 0; yi < board.GetLength (1); yi++) {
				GameObject tile = Instantiate (Resources.Load ("TilePassable"), new Vector3 (xi, yi, 0), Quaternion.identity) as GameObject;
				tile.transform.SetParent (transform);
			}
		}
	}
}