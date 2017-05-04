using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineEnemyController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		this.transform.Rotate (0, 0, 2);
	}
}
