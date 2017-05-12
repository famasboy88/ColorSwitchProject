using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeTrick : MonoBehaviour {

	void Start(){
		float rand = Random.Range (transform.position.y-0.2090f, transform.position.y + 0.2090f);
		transform.position = new Vector3 (0f,rand,0f);
		this.gameObject.GetComponent<CircleCollider2D> ().radius = 2f;
	}
}
