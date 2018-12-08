using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraController : MonoBehaviour {

	[SerializeField] private Transform target;
	private Vector3 offset = new Vector3(-10,20,-25);

	private void Update () {
		transform.position = target.position + offset;
		transform.LookAt(target.position);
	}
}
