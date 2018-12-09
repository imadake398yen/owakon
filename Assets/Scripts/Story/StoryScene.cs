using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryScene : MonoBehaviour {

    public GameObject slide1;
    public GameObject slide2;
    public GameObject slide3;
    public GameObject slide4;

    int currentPageNumber = 0;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            currentPageNumber++;
            if (currentPageNumber == 1)
            {
                slide1.SetActive(false);
                slide2.SetActive(true);
            }else if (currentPageNumber == 2)
            {
                slide2.SetActive(false);
                slide3.SetActive(true);
            }else if (currentPageNumber == 3)
            {
                slide3.SetActive(false);
                slide4.SetActive(true);
            }else if (currentPageNumber == 4)
            {
                slide4.SetActive(true);
                ChangeScene.ChangeSceneTo("Main");
            }
        }
    }
}
