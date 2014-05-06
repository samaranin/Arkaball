/// <summary>
/// Block.cs
/// Date: 26.02.2014
/// Author: Michael Boyko
/// </summary>
using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {
	
	public BlockType blockType = BlockType.Green;
	
	public int points = 10;

	// Use this for initialization
	void Start () {
		MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
		
		meshRenderer.material = Resources.Load( "BlockMaterials/Block" + blockType.ToString() ) as Material;
		switch ( blockType ) {
			
			case BlockType.Green:
				meshRenderer.material = Resources.Load( "BlockMaterials/BlockGreen" ) as Material;
				break;
			
			case BlockType.Blue:
				meshRenderer.material = Resources.Load( "BlockMaterials/BlockBlue" ) as Material;
				break;
			
			default:
				meshRenderer.material = Resources.Load( "BlockMaterials/BlockRed" ) as Material;
				break;
			
		} 
	}
	
	void OnCollisionEnter ( Collision collision ) {
		Score.score += (int) blockType;
		Destroy( gameObject );
	}
	
}

public enum BlockType {
	Red = 10,
	Green = 20,
	Blue = 30
}
