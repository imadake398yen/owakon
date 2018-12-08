using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelRolling : Obstacle {

    public int force = 10;
    private Rigidbody barrel_rigidbody = null;
    private bool isPlaying = false;

    // Use this for initialization
    private void Awake() {
        barrel_rigidbody = GetComponent<Rigidbody>();
    }

	public void Play () {
        base.Play();
        isPlaying = true;
    }

    // Update is called once per frame
    void Update () {
        if (!isPlaying) return;
        barrel_rigidbody.AddForce(0,0,-force);
	}
}
