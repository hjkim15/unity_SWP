using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JiHyeShotDirector : MonoBehaviour
{
    public static JiHyeShotDirector instance = null;

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

    GameObject shot1;
    GameObject shot2;
    GameObject shot3;

    int count;
    public int price;

    public AudioClip click;
    AudioSource aud;
    bool bAudioPlay = false;

    void Start()
    {
        InitialDirector.instance.totalsCount += 1;

        this.aud = GetComponent<AudioSource>();

        Camera = GameObject.Find("Main Camera").GetComponent<Camera>();
        this.shot1 = GameObject.Find("shot1");
        this.shot2 = GameObject.Find("shot2");
        this.shot3 = GameObject.Find("shot3");

        Debug.Log(JiHyeController.instance.shot);
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

            if (MousePosition.x >= -7.4f && MousePosition.x <= -5.7f && MousePosition.y >= -3.4f && MousePosition.y <= -1.0f && JiHyeController.instance.shot == 0)
            {
                if (bAudioPlay == false)
                {
                    bAudioPlay = true;
                    this.aud.PlayOneShot(this.click);
                }
                this.shot1.transform.localScale = new Vector3(1.294566f, 1.32f, 0);
                price = 1000;
            }
            else if (MousePosition.x >= -1.4f && MousePosition.x <= 1.5f && MousePosition.y >= -3.4f && MousePosition.y <= -1.0f && JiHyeController.instance.shot == 1)
            {
                if (bAudioPlay == false)
                {
                    bAudioPlay = true;
                    this.aud.PlayOneShot(this.click);
                }
                this.shot2.transform.localScale = new Vector3(1.332316f, 1.590558f, 0);
                price = 1000;
            }
            else if (MousePosition.x >= 4.2f && MousePosition.x <= 8.4f && MousePosition.y >= -3.4f && MousePosition.y <= -1.0f && JiHyeController.instance.shot == 2)
            {
                if (bAudioPlay == false)
                {
                    bAudioPlay = true;
                    this.aud.PlayOneShot(this.click);
                }
                this.shot3.transform.localScale = new Vector3(1.1432f, 1.3776f, 0);
                price = 1000;
            }
        }

        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            SceneManager.LoadScene("AfterJiHyeScene");
        }
    }
}
