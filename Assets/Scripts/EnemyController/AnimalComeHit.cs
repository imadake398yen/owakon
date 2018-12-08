using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalComeHit : Obstacle {

    [SerializeField]
    private int MaxChild = 5;
    private GameObject BoidsChild;
    private GameObject[] BoidsChildren;

	// Use this for initialization
    private void Start (){

    }

	// Update is called once per frame
	public void Play () {
        base.Play();
        this.BoidsChildren = new GameObject[MaxChild];

        for (int i = 0; i < this.MaxChild; i++){
                this.BoidsChildren[i] = GameObject.Instantiate(BoidsChild) as GameObject;

                this.BoidsChildren[i].transform.position = new Vector3(Random.Range(-50f, 50f),this.BoidsChild.transform.position.y,Random.Range(-50f, 50f));
        }

	}

    void OnMouseDown(){
        Play();
    }

}
