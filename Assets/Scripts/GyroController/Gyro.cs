﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gyro : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        var q = Input.gyro.attitude;
        Debug.Log(q);
    }
}
