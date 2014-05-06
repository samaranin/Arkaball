/// <summary>
/// Lives.cs
/// Date: 26.02.2014
/// Author: Michael Boyko
/// </summary>
using UnityEngine;
using System.Collections;

public class Lives : MonoBehaviour {
	
	public int startingLives = 3;
	public static int currentLives = 0;

	// Use this for initialization
	void Start () {
		currentLives = startingLives;
	}
	
	// Update is called once per frame
	void Update () {
		guiText.text = "Lives: " + currentLives.ToString();
	}
}
