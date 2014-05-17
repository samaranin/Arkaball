using UnityEngine;
using System.Collections;

public class DestroyBlock : MonoBehaviour {

	private GameObject thisGameObject;
	private Transform thisTransform;
	private int curLevel;

	void Awake() { //Caching the objects
		thisGameObject = gameObject;
		thisTransform = transform;
	}

	void OnCollisionEnter2D(Collision2D collision) {
		curLevel = Application.loadedLevel;
		if(thisTransform.parent.childCount == 1) //If the last block is broken change the level
		{
			Application.LoadLevel(curLevel+1);
		} else { //Else destroy this block
			Score.curScore += 10;
			Destroy(thisGameObject);
		}
	}
}
