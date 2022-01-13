using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HongCreamDirector : MonoBehaviour
{
    public static HongCreamDirector instance = null;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            if (instance != this)
                Destroy(this.gameObject);
        }
    }

    float delta = 0;
    float span = 5.0f;

    Vector2 MousePosition;
    Camera Camera;

    GameObject espresso;
    GameObject whip;

    int count;
    public int price;

    public AudioClip click;
    AudioSource aud;
    bool bAudioPlay = false;

    void Start()
    {
        Initial2Director.instance.totalpCount += 1;

        this.aud = GetComponent<AudioSource>();

        Camera = GameObject.Find("Main Camera").GetComponent<Camera>();
        this.espresso = GameObject.Find("espresso");
        this.whip = GameObject.Find("whip");

        Debug.Log(HongController.instance.cream);
        count = 0;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && count == 0)
        {
            count++;
            MousePosition = Input.mousePosition;
            MousePosition = Camera.ScreenToWorldPoint(MousePosition);

            transform.position = MousePosition;
            Debug.Log(MousePosition);

            if (MousePosition.x >= -4.7f && MousePosition.x <= -3.5f && MousePosition.y >= -3.3f && MousePosition.y <= 1.2f && HongController.instance.cream == 0)
            {
                if (bAudioPlay == false)
                {
                    bAudioPlay = true;
                    this.aud.PlayOneShot(this.click);
                }
                this.espresso.transform.localScale = new Vector3(0.8f, 0.8f, 0);
                price = 1000;
            }
            else if (MousePosition.x >= 3.3f && MousePosition.x <= 4.5f && MousePosition.y >= -3.3f && MousePosition.y <= 1.2f && HongController.instance.cream == 1)
            {
                if (bAudioPlay == false)
                {
                    bAudioPlay = true;
                    this.aud.PlayOneShot(this.click);
                }
                this.whip.transform.localScale = new Vector3(0.8f, 0.8f, 0);
                price = 1000;
            }
        }

        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            SceneManager.LoadScene("AfterHongScene");
        }
    }
}
