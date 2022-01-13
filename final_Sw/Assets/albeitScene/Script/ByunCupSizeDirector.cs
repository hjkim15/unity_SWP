using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ByunCupSizeDirector : MonoBehaviour
{
    public static ByunCupSizeDirector instance = null;

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

    GameObject small;
    GameObject medium;
    GameObject tall;

    int count;
    public int price;

    public AudioClip click;
    AudioSource aud;
    bool bAudioPlay = false;

    void Start()
    {
        this.aud = GetComponent<AudioSource>();

        Camera = GameObject.Find("Main Camera").GetComponent<Camera>();
        this.small = GameObject.Find("small");
        this.medium = GameObject.Find("medium");
        this.tall = GameObject.Find("tall");

        Debug.Log(ByunController.instance.cupSize);
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

            if (MousePosition.x >= -6.1f && MousePosition.x <= -4.0f && MousePosition.y >= -2.3f && MousePosition.y <= 0.4f && ByunController.instance.cupSize == 0)
            {
                if (bAudioPlay == false)
                {
                    bAudioPlay = true;
                    this.aud.PlayOneShot(this.click);
                }
                this.small.transform.localScale = new Vector3(0.7f, 0.7f, 0);
                price = 1000;
            }

            else if (MousePosition.x >= -1.0f && MousePosition.x <= 1.0f && MousePosition.y >= -2.5f && MousePosition.y <= 0.6f && ByunController.instance.cupSize == 1)
            {
                if (bAudioPlay == false)
                {
                    bAudioPlay = true;
                    this.aud.PlayOneShot(this.click);
                }
                this.medium.transform.localScale = new Vector3(0.7f, 0.7f, 0);
                price = 1000;
            }

            else if (MousePosition.x >= 3.9f && MousePosition.x <= 6.1f && MousePosition.y >= -2.7f && MousePosition.y <= 0.9f && ByunController.instance.cupSize == 2)
            {
                if (bAudioPlay == false)
                {
                    bAudioPlay = true;
                    this.aud.PlayOneShot(this.click);
                }
                this.tall.transform.localScale = new Vector3(0.8f, 0.8f, 0);
                price = 1000;
            }
        }
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            SceneManager.LoadScene("ByunLiquidScene");
        }
    }
}
