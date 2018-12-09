using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fukidash : MonoBehaviour {

    [SerializeField] private Text label;
    private Animator animator;

    string[] good = {
        "まだこんなところで死ぬわけにはいかない…",
        "失敗...",
        "成功！"
    };

    string[] mainScene = {
        "まだこんなところで死ぬわけにはいかない...",
        "ヒメが待ってるんだ、、早く帰らないと...",
        "おれの帰りを待ってくれてる人がいる。それだけで頑張れる。"
    };

    private void Start() {
        animator = GetComponent<Animator>();
        transform.localScale = Vector3.zero;
        if (SceneManager.GetActiveScene().name == "FailResult") {
            StartCoroutine(setSpeech(good[1]));
        }
        if (SceneManager.GetActiveScene().name == "SuccessResult") {
            StartCoroutine(setSpeech(good[2]));
        }
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.A)) {
            Play();
        }
    }

    public void Play () {
        var text = mainScene[Random.Range(0, mainScene.Length)];
        StartCoroutine(setSpeech(text));
    }

    IEnumerator setSpeech(string text) {
        animator.SetTrigger("Open");
        for (int i = 0; i <= text.Length; i++) {
            label.text = text.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
    }

}


