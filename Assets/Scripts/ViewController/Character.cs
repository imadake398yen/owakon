﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Model;

public class Character : SingletonMonoBehaviour<Character> {

    public float HitPoint { get; set; }
    public float Speed { get; set; }

    private int currentTarget = 0;
    private Transform target;
    private NavMeshAgent agent;
    private Animator animator;

    private void Start () {
        HitPoint = 100;
        target = StageManager.instance.Points[currentTarget];
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();
    }

    private void Update () {
        if (Stage.State != Const.StageState.BraveManHomecoming) return;
        animator.SetBool("isRun", true);

        var distance = Vector3.Distance(transform.position, target.position);
        agent.SetDestination(target.position);
        if (distance < 0.3f) {
            currentTarget += 1;
            if (StageManager.instance.Points.Count > currentTarget) {
                target = StageManager.instance.Points[currentTarget];
            }
        }
    }

    private void OnMouseDown () {
        Damage(Random.Range(0f, 10f));
    }

    public void Damage (float damage) {
        if (Stage.State != Const.StageState.BraveManHomecoming) return;
        HitPoint -= damage;
        HomecommingPanel.instance.Damage();
        if (HitPoint < 0) {
            HitPoint = 0;
        }
    }

}
