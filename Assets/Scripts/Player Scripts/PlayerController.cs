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
		int random = Random.Range (0, playerSprite.Length-1);
		this.setPlayerType (random);
		this.gameObject.GetComponent<SpriteRenderer> ().sprite = playerSprite [this.getPlayerType()];

		/*print (this.getPlayerType());*/
		/*print (playerSprite.Length);*/
	}
	


	void  OnTriggerEnter2D(Collider2D target){
		if(target.tag=="Enemy"){
			GameController.instance.setIsDead (true);
			GameController.instance.playerDied ();
			Destroy (this.gameObject);
		}
	}
}
