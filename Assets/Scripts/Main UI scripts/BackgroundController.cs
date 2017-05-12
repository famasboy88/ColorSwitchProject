using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour {


	private GameController background;
	private float backgroundLength=13.8f;
	Vector2 groundOffset;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y< -backgroundLength){
			repositionBackground ();
		}
	}

	void repositionBackground(){
		groundOffset = new Vector2 (0,backgroundLength*2f);
		transform.position = (Vector2)transform.position + groundOffset;
	}
}
