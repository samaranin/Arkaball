using UnityEngine;
using System.Collections;

public class Lives : MonoBehaviour {

	public static int currentLives = 3;
	
	// Update is called once per frame
	void Update () {
		guiText.text = "Lives: " + currentLives.ToString();
	}
}
