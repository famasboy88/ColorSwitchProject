using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchPadController : MonoBehaviour {
	
	public float upForce = 200f;
	public GameObject dynamicObj;
	private Rigidbody2D rb2d;
	private Vector3 lastPos;

	public GameObject player;



	void Start(){
		rb2d = dynamicObj.GetComponent<Rigidbody2D> ();
		lastPos = dynamicObj.transform.position;
	} 
		
	void playerJump(){
		if (GameController.instance.getIsDead () == false) {
			player.GetComponent<Rigidbody2D> ().gravityScale = 1f;
			player.GetComponent<Rigidbody2D> ().velocity = rb2d.velocity = new Vector2 (0f, 0f);
			player.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, upForce * 1));
			if (player.transform.position.y > -2.5f) {
				rb2d.AddForce (new Vector2 (0, upForce * -1));
			}

		}
	}

	void FixedUpdate(){
		if(GameController.instance.getIsDead()==false){
			if (dynamicObj.transform.position.y > lastPos.y) {
				rb2d.gravityScale = 0f;
				rb2d.velocity = new Vector2(0f,0f);
			} else {
				if(player.transform.position.y > 1f){
					rb2d.AddForce (new Vector2(0,-8f));
				}else if(player.transform.position.y > 2f){
					rb2d.AddForce (new Vector2(0,-11f));
				}
				rb2d.gravityScale = -1f;

			}
			if(dynamicObj.transform.position.y<lastPos.y){
				lastPos = dynamicObj.transform.position;
			}
		}else{
			rb2d.gravityScale = 0f;
			rb2d.velocity = new Vector2(0f,0f);
		}
	}
}
