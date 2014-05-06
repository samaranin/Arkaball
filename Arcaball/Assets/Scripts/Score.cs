/// <summary>
/// Score.cs
/// Date: 26.02.2014
/// Author: Michael Boyko
/// </summary>
using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	
	public static int score = 0;
	
	// Update is called once per frame
	void Update () {
		guiText.text = score.ToString();
	}
}
