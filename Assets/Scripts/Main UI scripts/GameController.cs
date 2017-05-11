
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	public static GameController instance;
	public GameObject gameOverText;
	public Text ScoreText;
	public Text HighScoreText;
	private int score=0;
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
		if(score > PlayerPrefs.GetInt("Highscore")){
			PlayerPrefs.SetInt ("Highscore",score);
		}
		HighScoreText.text = PlayerPrefs.GetInt ("Highscore").ToString();
		gameOverText.SetActive (true);
		gameOver = true;
	}

	public void playerScored(){
		if(gameOver){
			return;
		}
		score++;
		ScoreText.text = "Score: " + score.ToString ();

	}
}
