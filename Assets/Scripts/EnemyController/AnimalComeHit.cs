using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalComeHit : Obstacle {

    [SerializeField]
    private int MaxChild = 5;
    private GameObject AnimalsChild;
    private GameObject[] AnimalsChildren;

	// Use this for initialization
    private void Start (){

    }

	// Update is called once per frame
	public void Play () {
        base.Play();
        this.AnimalsChildren = new GameObject[MaxChild];

        for (int i = 0; i < this.MaxChild; i++){
                this.AnimalsChildren[i] = GameObject.Instantiate(AnimalsChild) as GameObject;

                this.AnimalsChildren[i].transform.position = new Vector3(this.AnimalsChild.transform.position.x, this.AnimalsChild.transform.position.y, Random.Range(-50f, 50f));
        }

	}

    void OnMouseDown(){
        Play();
    }

}
