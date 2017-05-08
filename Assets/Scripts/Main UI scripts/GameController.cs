
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
	public static GameController instance;
	public GameObject gameOverText;
	public bool gameOver = false;
	private bool isDead = false;

	void Awake(){
		if(instance==null){
			instance = this;
		}else if(instance!=this){
			Destroy (this.gameObject);
		}
	}

	public void setIsDead(bool var){
		this.isDead = var;
	}

	public bool getIsDead(){
		return this.isDead;
	}

	void FixedUpdate(){
		if(gameOver == true && Input.GetMouseButtonDown(0)){
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
			gameOver = false;
		}
	}

	public void playerDied(){
		gameOverText.SetActive (true);
		gameOver = true;
	}
}
