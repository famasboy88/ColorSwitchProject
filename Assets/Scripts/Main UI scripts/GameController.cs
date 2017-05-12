
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
	public float CameraShake=0.1f;
	public float CameraShakeLenth=1f;

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
		gameObject.GetComponent<CameraShakeController> ().shake (CameraShake,CameraShakeLenth);
		if(score > PlayerPrefs.GetInt("Highscore")){
			PlayerPrefs.SetInt ("Highscore",score);
		}
		HighScoreText.text = PlayerPrefs.GetInt ("Highscore").ToString();
		gameOver = true;
		Invoke ("doSetActive",0.5f);
	}

	public void playerScored(){
		if(gameOver){
			return;
		}
		score++;
		ScoreText.text = "Score: " + score.ToString ();

	}

	void doSetActive(){
		gameOverText.SetActive (true);
	}
}
