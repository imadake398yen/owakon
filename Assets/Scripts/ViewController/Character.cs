using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Model;

public class Character : SingletonMonoBehaviour<Character> {

    public int HitPoint { get; set; }
    public float Speed { get; set; }

    private int currentTarget = 0;
    private Transform target;
    private NavMeshAgent agent;

    private void Start () {
        target = StageManager.instance.Points[currentTarget];
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update () {
        if (Stage.State != Const.StageState.BraveManHomecoming) return;

        var distance = Vector3.Distance(transform.position, target.position);
        if (distance < 0.3f) {
            currentTarget += 1;
            if (StageManager.instance.Points.Count > currentTarget) {
                target = StageManager.instance.Points[currentTarget];
                agent.SetDestination(target.position);
            }
        }
    }

}
