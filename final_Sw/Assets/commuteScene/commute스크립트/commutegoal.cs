using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class commutegoal : MonoBehaviour
{
    public AudioClip success;
    AudioSource aud;
    GameObject player;
    public GameObject director;
    public GameObject gameobject;
    // Start is called before the first frame update
    void Start()
    {
        this.aud = GetComponent<AudioSource>();
        this.player = GameObject.Find("character");
        this.director = GameObject.Find("commuteGameDirector");
        this.gameobject = GameObject.Find("gameobject");
        DontDestroyOnLoad(gameobject);
    }

    // Update is called once per frame
    void Update()
    {
        this.gameobject.GetComponent<commuteGameObject>().time = this.director.GetComponent<commuteGameDirector>().time;
        this.gameobject.GetComponent<commuteGameObject>().rotate = GameObject.Find("clock2").transform.rotation.z;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.aud.PlayOneShot(this.success);
        this.player.GetComponent<commuteController>().moveSpeed = 0;
        Invoke("stops", 3);
        
    }

    void stops() {
        SceneManager.LoadScene("commute_climb");
        
    }
}
