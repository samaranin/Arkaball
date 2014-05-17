using UnityEngine;
using System.Collections;


public class Menu : MonoBehaviour { 
	
	public int window; 
	public GUIStyle guiStyle;
	
	void Start () { 
		window = 1; 
		Score.curScore = 0;
	} 
	
	void OnGUI () { 
		GUI.BeginGroup (new Rect (Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 200)); 
		if(window == 1) 
		{ 
			if(GUI.Button (new Rect (10,30,180,30), "Play"))
			{
				window = 2;   
			} 
			if(GUI.Button (new Rect (10,70,180,30), "About")) 
			{ 
				window = 3; 
			} 
			if(GUI.Button (new Rect (10,110,180,30), "Exit")) 
			{ 
				window = 4; 
			} 
		} 
		
		if(window == 2) 
		{ 
			GUI.Label(new Rect(50, 10, 180, 30), "Choose level");   
			if(GUI.Button (new Rect (10,40,180,30), "Level 1")) 
			{ 
				Debug.Log("Уровень 1 загружен"); 
				Application.LoadLevel("Level1"); 
			} 
			if(GUI.Button (new Rect (10,80,180,30), "Level 2")) 
			{ 
				Debug.Log("Уровень 2 загружен"); 
				Application.LoadLevel("Level2"); 
			} 
			if(GUI.Button (new Rect (10,120,180,30), "Level 3")) 
			{ 
				Debug.Log("Уровень 3 загружен"); 
				Application.LoadLevel("Level3"); 
			} 
			if(GUI.Button (new Rect (10,160,180,30), "Back")) 
			{ 
				window = 1; 
			} 
		} 

		
		if(window == 3) 
		{ 
			GUI.Label(new Rect(50, 10, 180, 30), "About");   
			GUI.Label(new Rect( 10, 40, 180, 40), "About game and help"); 
			if(GUI.Button (new Rect (10,90,180,30), "Back")) 
			{ 
				window = 1; 
			}   
		} 
		
		if(window == 4) 
		{ 
			GUI.Label(new Rect(50, 10, 180, 30), "Do you want to leave us?");   
			if(GUI.Button (new Rect (10,40,180,30), "Yes")) 
			{ 
				Application.Quit(); 
			} 
			if(GUI.Button (new Rect (10,80,180,30), "No")) 
			{ 
				window = 1; 
			} 
		} 
		GUI.EndGroup (); 
	} 
} 
