using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour {

    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void ChangeSceneTo(string sceneName)
    {
        _ChangeSceneTo(sceneName);
    }

    private static void _ChangeSceneTo(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}
