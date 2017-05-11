using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScoreController : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D player){
		if(player.tag=="Player"){
			GameController.instance.playerScored ();
		}

	}
}
