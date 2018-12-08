using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrelRolling : MonoBehaviour {

    public int force = 10;
    private Rigidbody barrel_rigidbody = null;

    // Use this for initialization
    private void Awake()
    {
        barrel_rigidbody = GetComponent<Rigidbody>();
    }
	void Start () {
    }
    
    // Update is called once per frame
    void Update () {
        barrel_rigidbody.AddForce(0,0,-force);
		
	}
}
