using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeeJoSyrupScene : MonoBehaviour
{
    public static HeeJoSyrupScene instance = null;

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

    GameObject vanilla;
    GameObject mocha;
    GameObject maple;

    int count;
    public int price;

    public AudioClip click;
    AudioSource aud;
    bool bAudioPlay = false;

    void Start()
    {
        this.aud = GetComponent<AudioSource>();

        Camera = GameObject.Find("Main Camera").GetComponent<Camera>();
        this.vanilla = GameObject.Find("vanilla");
        this.mocha = GameObject.Find("mocha");
        this.maple = GameObject.Find("maple");

        Debug.Log(HeeJoController.instance.syrup);
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

            if (MousePosition.x >= -6.4f && MousePosition.x <= -5.1f && MousePosition.y >= -3.5f && MousePosition.y <= 2.3f && HeeJoController.instance.syrup == 0)
            {
                if (bAudioPlay == false)
                {
                    bAudioPlay = true;
                    this.aud.PlayOneShot(this.click);
                }
                this.vanilla.transform.localScale = new Vector3(1.1f, 1.1f, 0);
                price = 1000;
            }
            else if (MousePosition.x >= -0.6f && MousePosition.x <= 0.6f && MousePosition.y >= -3.5f && MousePosition.y <= 2.3f && HeeJoController.instance.syrup == 1)
            {
                if (bAudioPlay == false)
                {
                    bAudioPlay = true;
                    this.aud.PlayOneShot(this.click);
                }
                this.mocha.transform.localScale = new Vector3(1.1f, 1.1f, 0);
                price = 1000;
            }
            else if (MousePosition.x >= 6.2f && MousePosition.x <= 7.5f && MousePosition.y >= -3.5f && MousePosition.y <= 2.3f && HeeJoController.instance.syrup == 2)
            {
                if (bAudioPlay == false)
                {
                    bAudioPlay = true;
                    this.aud.PlayOneShot(this.click);
                }
                this.maple.transform.localScale = new Vector3(1.1f, 1.1f, 0);
                price = 1000;
            }

        }

        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            SceneManager.LoadScene("HeeJoShotScene");
        }
    }
}
