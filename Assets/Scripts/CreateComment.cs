using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreateComment : MonoBehaviour
{

    public Text label;

    string[] good = {
        "まだこんなところで死ぬわけにはいかない…",
        "失敗...",
        "成功！"
};

    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "FailResult")
        {
            StartCoroutine(setSpeech(good[1]));
        }

        if (SceneManager.GetActiveScene().name == "SuccessResult")
        {
            StartCoroutine(setSpeech(good[2]));
        }

    }

    void Update()
    {

        if (Input.GetKey(KeyCode.A))//A
        {
            //StartCoroutine(setSpeech(good[UnityEngine.Random.Range(0, good.Length-1)]));
            StartCoroutine(setSpeech(good[0]));
        }
    }

    IEnumerator setSpeech(string text)
    {
        for (int i = 0; i <= text.Length; i++)
        {
            label.text = text.Substring(0, i);
            yield return new WaitForSeconds(0.1f);
        }
    }
}


