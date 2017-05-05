using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchPadController : MonoBehaviour {
	
	public float upForce = 200f;
	public GameObject dynamicObj;
	private Rigidbody2D rb2d;
	private Vector3 lastPos;
<<<<<<< HEAD
	private bool isDead=false;

	public void setIsDead(bool var){
		this.isDead = var;
	}

	public bool getIsDead(){
		return this.isDead;
	}
	/*public GameObject mainCam;
	Vector3 offset;
	public Vector3 PlayerlastPos = new Vector3(0f,0f,0f);*/
=======
	public GameObject GameController;
	public GameObject player;

>>>>>>> origin/master


	void Start(){
		rb2d = dynamicObj.GetComponent<Rigidbody2D> ();
		lastPos = dynamicObj.transform.position;
	} 
<<<<<<< HEAD

	public void playerJump(){
		if(this.isDead==false){
			this.gameObject.GetComponent<Rigidbody2D> ().gravityScale = 1f;
			this.gameObject.GetComponent<Rigidbody2D> ().velocity = rb2d.velocity = new Vector2(0f,0f);
			if(this.gameObject.transform.position.y>-0.63f){
				rb2d.AddForce (new Vector2(0,upForce*-1));
			}
			if(this.gameObject.transform.position.y<4.7f){
				this.gameObject.GetComponent<Rigidbody2D> ().AddForce (new Vector2(0,upForce*1));
=======
		
	void playerJump(){
		if (GameController.GetComponent<GameController> ().getIsDead () == false) {
			player.GetComponent<Rigidbody2D> ().gravityScale = 1f;
			player.GetComponent<Rigidbody2D> ().velocity = rb2d.velocity = new Vector2 (0f, 0f);
			if (player.transform.position.y > -1) {
				rb2d.AddForce (new Vector2 (0, upForce * -1));
			}
			if (player.transform.position.y < 4.7f) {
				player.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, upForce * 1));
>>>>>>> origin/master
			}
		}
	}

	void FixedUpdate(){
<<<<<<< HEAD
		if(this.isDead==false){
=======
		if(GameController.GetComponent<GameController> ().getIsDead()==false){
>>>>>>> origin/master
			if (dynamicObj.transform.position.y > lastPos.y) {
				rb2d.gravityScale = 0f;
				rb2d.velocity = new Vector2(0f,0f);
			} else {
				rb2d.gravityScale = -1f;
			}
<<<<<<< HEAD
			if(dynamicObj.transform.position.y<=lastPos.y){
				lastPos = dynamicObj.transform.position;
			}
		}else{
			dynamicObj.transform.position = lastPos;
			rb2d.gravityScale = 0f;
			rb2d.velocity = new Vector2(0f,0f);	

=======
			if(dynamicObj.transform.position.y<lastPos.y){
				lastPos = dynamicObj.transform.position;
			}
		}else{
			rb2d.gravityScale = 0f;
			rb2d.velocity = new Vector2(0f,0f);
>>>>>>> origin/master
		}
		print (this.isDead==false);
	
	}
}
