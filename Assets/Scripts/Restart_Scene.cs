using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Restart_Scene : MonoBehaviour {
	static int Total_Num_Of_Tiles;
	static int Total_Num_Of_Pathmakers;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.R)) {
			
				//Total_Num_Of_Tiles = 0;
				//Total_Num_Of_Pathmakers = 0;
				//counter = 0;
				SceneManager.LoadScene (0);

		}
	}
}