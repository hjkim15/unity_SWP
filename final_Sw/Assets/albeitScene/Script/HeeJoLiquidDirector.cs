using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeeJoLiquidDirector : MonoBehaviour
{
    public static HeeJoLiquidDirector instance = null;

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

    GameObject milk;
    GameObject lightMilk;
    GameObject ice;
    GameObject hot;

    int count;
    public int price;

    public AudioClip click;
    AudioSource aud;
    bool bAudioPlay = false;

    void Start()
    {
        this.aud = GetComponent<AudioSource>();

        Camera = GameObject.Find("Main Camera").GetComponent<Camera>();
        this.milk = GameObject.Find("milk");
        this.lightMilk = GameObject.Find("light milk");
        this.ice = GameObject.Find("ice");
        this.hot = GameObject.Find("hot");

        Debug.Log(HeeJoController.instance.liquid);
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

            if (MousePosition.x >= -7.4f && MousePosition.x <= -4.5f && MousePosition.y >= -3.3f && MousePosition.y <= 1.3f && HeeJoController.instance.liquid == 0)
            {
                if (bAudioPlay == false)
                {
                    bAudioPlay = true;
                    this.aud.PlayOneShot(this.click);
                }
                this.milk.transform.localScale = new Vector3(1.1f, 1.1f, 0);
                price = 1000;
            }
            else if (MousePosition.x >= -3.3f && MousePosition.x <= -0.5f && MousePosition.y >= -3.3f && MousePosition.y <= 1.3f && HeeJoController.instance.liquid == 1)
            {
                if (bAudioPlay == false)
                {
                    bAudioPlay = true;
                    this.aud.PlayOneShot(this.click);
                }
                this.lightMilk.transform.localScale = new Vector3(1.1f, 1.1f, 0);
                price = 1000;
            }
            else if (MousePosition.x >= 0.9f && MousePosition.x <= 3.2f && MousePosition.y >= -2.5f && MousePosition.y <= 0.5f && HeeJoController.instance.liquid == 2)
            {
                if (bAudioPlay == false)
                {
                    bAudioPlay = true;
                    this.aud.PlayOneShot(this.click);
                }
                this.ice.transform.localScale = new Vector3(1.1f, 1.1f, 0);
                price = 1000;
            }
            else if (MousePosition.x >= 5.0f && MousePosition.x <= 7.2f && MousePosition.y >= -2.5f && MousePosition.y <= 0.5f && HeeJoController.instance.liquid == 3)
            {
                if (bAudioPlay == false)
                {
                    bAudioPlay = true;
                    this.aud.PlayOneShot(this.click);
                }
                this.hot.transform.localScale = new Vector3(1.1f, 1.1f, 0);
                price = 1000;
            }
        }

        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            SceneManager.LoadScene("HeeJoSyrupScene");
        }
    }
}
