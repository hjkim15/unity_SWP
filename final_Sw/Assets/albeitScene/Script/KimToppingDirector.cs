using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KimToppingDirector : MonoBehaviour
{
    public static KimToppingDirector instance = null;

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

    GameObject cereal;
    GameObject chocolate;
    GameObject snack;

    int count;
    public int price;

    public AudioClip click;
    AudioSource aud;
    bool bAudioPlay = false;

    void Start()
    {
        this.aud = GetComponent<AudioSource>();

        Camera = GameObject.Find("Main Camera").GetComponent<Camera>();
        this.cereal = GameObject.Find("cereal");
        this.chocolate = GameObject.Find("chocolate");
        this.snack = GameObject.Find("snack");

        Debug.Log(KimController.instance.topping);
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

            if (MousePosition.x >= -7.4f && MousePosition.x <= -3.8f && MousePosition.y >= -1.9f && MousePosition.y <= 0.8f && KimController.instance.topping == 0)
            {
                if (bAudioPlay == false)
                {
                    bAudioPlay = true;
                    this.aud.PlayOneShot(this.click);
                }
                this.cereal.transform.localScale = new Vector3(1.1f, 1.1f, 0);
                price = 1000;
            }
            else if (MousePosition.x >= -1.8f && MousePosition.x <= 1.7f && MousePosition.y >= -1.9f && MousePosition.y <= 0.8f && KimController.instance.topping == 1)
            {
                if (bAudioPlay == false)
                {
                    bAudioPlay = true;
                    this.aud.PlayOneShot(this.click);
                }
                this.chocolate.transform.localScale = new Vector3(1.3f, 1.3f, 0);
                price = 1000;
            }
            else if (MousePosition.x >= 3.7f && MousePosition.x <= 7.3f && MousePosition.y >= -1.9f && MousePosition.y <= 0.8f && KimController.instance.topping == 2)
            {
                if (bAudioPlay == false)
                {
                    bAudioPlay = true;
                    this.aud.PlayOneShot(this.click);
                }
                this.snack.transform.localScale = new Vector3(1.1f, 1.1f, 0);
                price = 1000;
            }
        }

        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            SceneManager.LoadScene("KimCreamScene");
        }
    }
}
