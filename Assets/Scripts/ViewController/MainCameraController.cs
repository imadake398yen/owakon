using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraController
: SingletonMonoBehaviour<MainCameraController> {

	[SerializeField] private Const.CameraState _state = Const.CameraState.ChaseTarget;
	public Const.CameraState State { get{ return _state; } }
	public void ChangeState (Const.CameraState state) { _state = state; }

	[SerializeField] private Transform target;
	private float sensitivity = .001f;
	private Vector3 offset = new Vector3(0,14,-14);
	private Vector3 lastPointerPosition, scrollDistance;

	private Camera camera;
	private void Start () {
		camera = GetComponent<Camera>();
	}

	private void Update () {
		if (Input.GetMouseButtonDown(0)) {
			lastPointerPosition = Input.mousePosition;
		}
		if (Input.GetMouseButton(0)) {
			if (Vector2.Distance(lastPointerPosition, Input.mousePosition) > 3) {
				if (_state != Const.CameraState.PlaceObstacle) {
					_state = Const.CameraState.Scroll;
					scrollDistance = Input.mousePosition - lastPointerPosition;
				}
			}
		}
		if (Input.GetMouseButtonUp(0)) {
			scrollDistance = Vector3.zero;
		}
		switch (_state) {
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
			case Const.CameraState.PlaceObstacle:
				if (Placer.SelectedObstacle == null) break;
				if (Input.GetMouseButtonDown(0)) {
					RaycastHit hit;
					Ray ray = camera.ScreenPointToRay(Input.mousePosition);
					if (Physics.Raycast(ray, out hit)) {
						var obstacle = Instantiate(Placer.SelectedObstacle) as Obstacle;
						obstacle.transform.position = hit.point;
						ChangeState(Const.CameraState.Scroll);
						Placer.CancelSelect();
					}
				}
				break;
			default: break;
		}
	}
}
