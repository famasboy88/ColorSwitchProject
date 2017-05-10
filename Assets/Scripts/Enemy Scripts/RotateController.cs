using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateController : MonoBehaviour {

	public bool isClockwise=true;
	public float speed=2f;

	// Update is called once per frame
	void FixedUpdate () {
		if(isClockwise){
			this.transform.Rotate (0, 0, speed);
		}else{
			this.transform.Rotate (0, 0, -speed);
		}

	}
}
