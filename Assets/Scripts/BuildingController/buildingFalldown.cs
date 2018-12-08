using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildingFalldown : MonoBehaviour {

    private Rigidbody b_rigidbody = null;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        b_rigidbody.AddTorque(transform.right, ForceMode.Force);
    }
}
