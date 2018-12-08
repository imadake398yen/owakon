using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScorer : MonoBehaviour
{

    public int score
    {
        get
        {
            if (this.gameObject.tag == "taru")
            {
                return 10;
            } else if (this.gameObject.tag == "")
            {
                return 20;
            }
            else
            {
                return 30;
            }
        }
    };


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {

        }
    }
}
