using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.AI;

public class NavMoveScript : MonoBehaviour {

public Transform destination; //目標先
UnityEngine.AI.NavMeshAgent agent; //NavMeshAgent

	// Use this for initialization
	void Start () {
			agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
	}

	void Update () {
		agent.SetDestination(destination.position);
	}


	// //キューブのTransform(Inspector上でアタッチ)
	// [SerializeField]
	// private Transform _cube;

	// //NavMeshAgent(Inspector上でアタッチ)
	// [SerializeField]
	// private UnityEngine.AI.NavMeshAgent _navMeshAgent = null;

	// private void Update () {
	// 	_navMeshAgent.destination = _cube.position;
	// }
}
