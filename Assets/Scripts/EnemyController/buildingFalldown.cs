using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildingFalldown : MonoBehaviour {

    [SerializeField]
    private float build_torqueForce = 0.0f;

    private Rigidbody build_rb = null;

    // Use this for initialization
    private void Awake()
    {
        build_rb = GetComponent<Rigidbody>();

    }
    void Start () {

        Vector3 rightVec = transform.right;
        Vector3 torque = rightVec * build_torqueForce;
        build_rb.AddTorque(torque, ForceMode.Force);

    }

    // Update is called once per frame
    void Update()
    {
    }
}
