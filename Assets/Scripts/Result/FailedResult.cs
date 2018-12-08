using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FailedResult : MonoBehaviour
{

    public Camera target;

    private void Start()
    {

    }

    private void Update()
    {
        target.transform.position += new Vector3(0, 0, 0.01f);
    }

}
