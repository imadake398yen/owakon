using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraController
: SingletonMonoBehaviour<MainCameraController> {

	[SerializeField] private Const.CameraState state = Const.CameraState.ChaseTarget;
	public Const.CameraState State { get{ return state; } }
	public void ToChaseState () { state = Const.CameraState.ChaseTarget; }

	[SerializeField] private Transform target;
	private float sensitivity = .001f;
	private Vector3 offset = new Vector3(-10,20,-25);
	private Vector3 lastPointerPosition, scrollDistance;

	private void Update () {
		if (Input.GetMouseButtonDown(0)) {
			lastPointerPosition = Input.mousePosition;
		}
		if (Input.GetMouseButton(0)) {
			if (Vector2.Distance(lastPointerPosition, Input.mousePosition) > 3) {
				state = Const.CameraState.Scroll;
				scrollDistance = Input.mousePosition - lastPointerPosition;
			}
		}
		if (Input.GetMouseButtonUp(0)) {
			scrollDistance = Vector3.zero;
		}
		switch (state) {
			case Const.CameraState.ChaseTarget:
				var moveTarget = target.position + offset;
				transform.position = Vector3.Lerp(
					transform.position,
					moveTarget,
					3f * Time.deltaTime
				);
				transform.LookAt(target.position);
				break;
			case Const.CameraState.Scroll:
				transform.position += new Vector3( scrollDistance.x, 0, scrollDistance.y ) * sensitivity;
				break;
			default: break;
		}
	}
}
