using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
		
		public static int curScore = 0;
		
		// Update is called once per frame
		void Update () {
			guiText.text = curScore.ToString();
		}
}
