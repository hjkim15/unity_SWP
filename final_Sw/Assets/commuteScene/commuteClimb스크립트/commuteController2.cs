using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class commuteController2 : MonoBehaviour
{
    public float power = 100.0f;
    public float xloc = 3.0f;
    public float yloc = 0.0f;
    float delta = 0;
    float span = 5.0f;
    public bool playerflag = true;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("move1");
        this.playerflag = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) { 

            if (transform.position.x >= 22) yloc = 1.0f;
            if (transform.position.x >= 66) yloc = 0.0f;
            if (transform.position.x >= 97) yloc = 5.0f;
            if (transform.position.x >= 116) yloc = 3.0f;
            if (transform.position.x >= 126) yloc = 5.0f;
            if (transform.position.x >= 152) yloc = 2.0f;
            if(this.playerflag)
                this.transform.Translate(new Vector2(xloc, yloc));
        }
        //Debug.Log(delta);

        delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;
            Vector3 loc = this.player.transform.position;
            if(this.playerflag)
                this.player.transform.position = new Vector3(loc.x - 3, loc.y, loc.z);
        }
    }


}
