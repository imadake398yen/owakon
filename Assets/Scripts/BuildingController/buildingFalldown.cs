using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildingFalldown : MonoBehaviour {

    [SerializeField]
    private float b_torqueForce = 0.0f;

    private Rigidbody b_rigidbody = null;

    // Use this for initialization
    private void Awake()
    {
        b_rigidbody = GetComponent<Rigidbody>();

    }
    void Start () {

        Vector3 rightVec = transform.right;
        Vector3 torque = rightVec * b_torqueForce;
        b_rigidbody.AddTorque(torque, ForceMode.Force);

    }

    // Update is called once per frame
    void Update()
    {
    }
}
