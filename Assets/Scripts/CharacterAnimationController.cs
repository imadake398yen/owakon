using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationController : MonoBehaviour {

    public GameObject player;

    public Animator animator;

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        if (animator.GetBool("isAliving"))
        {
            player.transform.position += Vector3.forward * 0.01f;
        }
    }
}
