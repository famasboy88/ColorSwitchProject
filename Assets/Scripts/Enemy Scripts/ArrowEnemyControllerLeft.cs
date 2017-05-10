using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowEnemyControllerLeft : MonoBehaviour {

	private float speed;
	public float fast;
	public float normal;
	public float dir = -1f;
	private float posLimit1 = 0.08510233f;
	private float posLimit2 = 0.9851021f;

	void FixedUpdate(){
		if(transform.position.x>=posLimit1 && transform.position.x<=posLimit2 || transform.position.x<=-posLimit1 && transform.position.x>=-posLimit2){
			speed = fast;
		}else{
			speed = normal;
		}
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
