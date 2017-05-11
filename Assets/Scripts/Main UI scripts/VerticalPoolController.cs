using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class VerticalPoolController : MonoBehaviour {

	public List<GameObject> levels;
	
	public GameObject[] ArrayPowerupHolder;
	//public GameObject prefabObj;
	public GameObject parentObj;
	//public int poolsize;
	private int randomLvl=0;

	//private Vector2 objPoolPos = new Vector2(0f,-2f);

	public float spawnPosition=10f;
	private Component[] scripts;

	public float positionLimit;
	private bool isLevelLoaded = false;

	void Start(){
		/*ArrayObjectsHolder = new GameObject[poolsize];
		for(int i=0;i<poolsize;i++){
			ArrayObjectsHolder [i] = (GameObject)Instantiate (prefabObj, objPoolPos, Quaternion.identity);
			ArrayObjectsHolder [i].transform.parent = parentObj.transform;
		}*/
		randomLvl = Random.Range (0,levels.Count);
		levels [randomLvl].transform.position = new Vector2 (0f,spawnPosition);
		levels [randomLvl].transform.parent = parentObj.transform;
		isLevelLoaded = true;

	}

	void Update(){
		if (GameController.instance.gameOver == false) {
			if(isLevelLoaded==false){
				randomLvl = Random.Range (0,levels.Count);
				levels [randomLvl].transform.position = new Vector2 (0f,spawnPosition);
				levels [randomLvl].transform.parent = parentObj.transform;
				scripts = levels [randomLvl].GetComponentsInChildren<RotateController> ();
				foreach(RotateController s in scripts){
					s.RandomRotation ();
				}

				for(int i = 0 ; i <ArrayPowerupHolder.Length;i++){
					ArrayPowerupHolder [i].SetActive (true);
				}
				isLevelLoaded = true;
			}
			if(levels[randomLvl].transform.position.y<=positionLimit){
				isLevelLoaded = false;
			}
		}
	}
}
