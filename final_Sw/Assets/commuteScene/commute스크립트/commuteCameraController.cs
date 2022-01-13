using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class commuteCameraController : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("character");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = this.player.transform.position;
        transform.position = new Vector3(playerPos.x, playerPos.y,-10);
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("character").GetComponent<commuteController>().moveSpeed = 1;
    }
    
}
