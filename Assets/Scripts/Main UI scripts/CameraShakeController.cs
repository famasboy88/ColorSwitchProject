using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShakeController : MonoBehaviour {

	public Camera mainCam;
	private float shakeamount=0;

	void Awake(){
		if(mainCam == null){
			mainCam =Camera.main;
		}
	}


	public void shake(float amt, float length){
		shakeamount = amt;
		InvokeRepeating ("BeginShake",0,0.02f);
		Invoke ("StopShake",length);
	}

	void BeginShake(){
		if(shakeamount>0){
			Vector3 camPos = mainCam.transform.position;

			float amtX = Random.value * shakeamount * 2 - shakeamount;
			float amtY = Random.value * shakeamount * 2 - shakeamount;
			camPos.x += amtX;
			camPos.y += amtY;

			mainCam.transform.position = camPos;
		}
	}

	void StopShake(){
		CancelInvoke ("BeginShake");
		mainCam.transform.localPosition = new Vector3 (0f,0f,-10f);
	}
}
