using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalPoolController : MonoBehaviour {
	private GameObject[] verticalObjects;
	private Vector2 objPoolPos = new Vector2(-15f,-25f);
	private float timeSinceLastSpawned;
	public float spawnRate=4f;
	public GameObject prefabObj;
	public int poolsize;

	void Start(){
		verticalObjects = new GameObject[poolsize];
		for(int i=0;i<poolsize;i++){
			verticalObjects [i] = (GameObject)Instantiate (prefabObj, objPoolPos, Quaternion.identity);
		}
	}

}
