using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineEnemyController : MonoBehaviour {
	public bool isClockwise=true;

	// Update is called once per frame
	void FixedUpdate () {
		if(isClockwise){
			this.transform.Rotate (0, 0, 2f);
		}else{
			this.transform.Rotate (0, 0, -2f);
		}

	}
}
