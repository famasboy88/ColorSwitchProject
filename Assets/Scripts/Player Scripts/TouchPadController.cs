using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchPadController : MonoBehaviour {

	public float upForce = 200f;
	private Rigidbody2D rb2d;

	public GameObject mainCam;
	Vector3 offset;
	public Vector3 PlayerlastPos = new Vector3(0f,0f,0f);


	void Start(){
		rb2d = GetComponent<Rigidbody2D> ();

		offset = mainCam.transform.position - this.transform.position;
		PlayerlastPos = gameObject.transform.position;
	} 

	public void playerJump(){
		rb2d.velocity = Vector2.zero;
		rb2d.AddForce (new Vector2(0,upForce));


	}

	void FixedUpdate(){
		if(gameObject.transform.position.y>=PlayerlastPos.y){
			mainCam.transform.position = gameObject.transform.position + offset;
		}
		if(PlayerlastPos.y<gameObject.transform.position.y){
			PlayerlastPos = gameObject.transform.position;
		}
	}
}
