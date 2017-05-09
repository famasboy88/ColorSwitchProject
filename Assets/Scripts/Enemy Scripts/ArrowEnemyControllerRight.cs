using UnityEngine;
using System.Collections;

public class ArrowEnemyControllerRight : MonoBehaviour
{


	public float speed = 3;
	public float dir = -1f;

	void Update(){
		transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * dir * speed);
	}

	//check if the object hits the other two cubes
	void OnTriggerEnter2D(Collider2D coll){
		//check if the object enter into a trigger with objects named Finish
		if(coll.tag=="bounceBack"){
			//reverse the current direction 
			dir *= -1;
		}
	}


}

