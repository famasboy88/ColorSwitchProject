using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public Sprite[] playerSprite;
	private int playerType;



	public void setPlayerType(int data){
		this.playerType = data;
	}

	public int getPlayerType(){
		return this.playerType;
	}

	// Use this for initialization
	void Start () {
		this.setPlayerType (0);
		this.gameObject.GetComponent<SpriteRenderer> ().sprite = playerSprite [0];

		/*print (this.getPlayerType());*/
		/*print (playerSprite.Length);*/
	}
	


	void  OnTriggerEnter2D(Collider2D target){
		if(target.tag=="Enemy"){
			GameController.instance.setIsDead (true);
			GameController.instance.playerDied ();
			Destroy (this.gameObject);
		}

		if (target.tag == "switchWhite") {
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = playerSprite [0];
			GameObject.FindGameObjectWithTag ("switchWhite").SetActive (false);
		} else if (target.tag == "switchBlue") {
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = playerSprite [1];
			GameObject.FindGameObjectWithTag ("switchBlue").SetActive (false);
		} else if (target.tag == "switchGreen") {
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = playerSprite [2];
			GameObject.FindGameObjectWithTag ("switchGreen").SetActive (false);
		} else if (target.tag == "switchOrange") {
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = playerSprite [3];
			GameObject.FindGameObjectWithTag ("switchOrange").SetActive (false);
		}
	}
}
