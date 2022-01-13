using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class commuteFlag3 : MonoBehaviour
{
    GameObject cameraLoc;
    GameObject player;
    bool visit = false;
    public AudioClip success;
    AudioSource aud;
    // Start is called before the first frame update
    void Start()
    {
        this.cameraLoc = GameObject.Find("Main Camera");
        this.player = GameObject.Find("move1");
        this.aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!visit)
        {
            this.aud.PlayOneShot(this.success);
            cameraLoc.GetComponent<commuteCameraController2>().flag = 3;
            visit = true;
        }
    }

}
