using UnityEngine;
using System.Collections;

public class ReturnToMenu : MonoBehaviour {
	void FixedUpdate () {
		if(Input.GetKey(KeyCode.Escape)) //If escape key is pressed...
		{
			Application.LoadLevel("Menu"); //Load the menu
		}
	}   
}