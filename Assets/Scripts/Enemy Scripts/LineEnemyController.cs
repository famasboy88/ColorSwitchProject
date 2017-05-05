using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineEnemyController : MonoBehaviour {

	
	// Update is called once per frame
	void FixedUpdate () {
		this.transform.Rotate (0, 0, 2);
	}
}
