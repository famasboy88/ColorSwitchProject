﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUIScript : MonoBehaviour {

	void OnBecameInvisible(){
		Destroy (this.gameObject);
	}
}
