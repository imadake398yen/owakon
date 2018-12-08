using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gyro : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var rotRH = Input.gyro.attitude;
        var rot = new Quaternion(-rotRH.x * 10f, -rotRH.z * 10f , -rotRH.y * 10f, rotRH.w) * Quaternion.Euler(90f, 0f, 0f);

        Debug.Log(rot);

        gameObject.transform.localRotation = rot;

    }
}
