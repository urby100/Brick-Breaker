﻿using UnityEngine;
using System.Collections;

public class DestroyExplosionParticle : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, 3);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
