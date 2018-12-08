using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FailedResult : MonoBehaviour
{

    public CreateComment createComment; // コメントの表示するタイミングを調整するために宣言。

    public Text label;
    public Image image;

    // Use this for initialization
    void Start()
    {
        createComment.enabled = false;
        label.enabled = false;
        image.enabled = false;
        //　1.5秒遅らせる
        StartCoroutine(HideObj());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator HideObj()
    {
        yield return new WaitForSeconds(1.5f);
        image.enabled = true;
        label.enabled = true;
        createComment.enabled = true;
    }

}
