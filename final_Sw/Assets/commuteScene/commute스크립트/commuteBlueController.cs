using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class commuteBlueController : MonoBehaviour
{
    GameObject cause;
    // Start is called before the first frame update
    void Start()
    {
        this.cause = GameObject.Find("commuteGameDirector");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject.Find("character").GetComponent<commuteController>().moveSpeed = 6.0f;
        if (transform.tag == "cause0")
        {
            this.cause.GetComponent<commuteGameDirector>().index = 0;
        }
        else if (transform.tag == "cause1")
        {
            this.cause.GetComponent<commuteGameDirector>().index = 1;
        }
        else if (transform.tag == "cause2")
        {
            this.cause.GetComponent<commuteGameDirector>().index = 2;
        }
        else if (transform.tag == "cause3")
        {
            this.cause.GetComponent<commuteGameDirector>().index = 3;
        }
        else if (transform.tag == "cause4")
        {
            this.cause.GetComponent<commuteGameDirector>().index = 4;
        }
        else if (transform.tag == "cause5")
        {
            this.cause.GetComponent<commuteGameDirector>().index = 5;
        }
        else if (transform.tag == "cause6")
        {
            this.cause.GetComponent<commuteGameDirector>().index = 6;
        }
        else if (transform.tag == "cause7")
        {
            this.cause.GetComponent<commuteGameDirector>().index = 7;
        }
    }

}
