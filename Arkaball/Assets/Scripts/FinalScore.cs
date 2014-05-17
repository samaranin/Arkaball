using UnityEngine;
using System.Collections;

public class FinalScore : MonoBehaviour {

	/// Update is called once per frame
	void Update () {
		guiText.text = "Your final score is: " + Score.curScore.ToString();
	}

	void FixedUpdate () {
		if(Input.GetKey(KeyCode.Escape)) //If escape key is pressed...
		{
			Application.LoadLevel("Menu"); //Load the menu
		}
	}   
}
