using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateComment : MonoBehaviour
{

    public Text label;

    string[] good = {
        "まだこんなところで死ぬわけにはいかない…",
        "まだまだ戦えるぜ",
};

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


