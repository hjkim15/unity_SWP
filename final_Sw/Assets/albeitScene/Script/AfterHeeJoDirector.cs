using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AfterHeeJoDirector : MonoBehaviour
{
    public static AfterHeeJoDirector instance = null;

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

    public int totalPrice;
    GameObject heejo0;
    GameObject heejo1;
    GameObject heejo2;
    GameObject talk;
    GameObject Talk;

    float delta = 0;
    float span = 2.0f;

    public AudioClip smileSE;
    public AudioClip angrySE;
    public AudioClip bestHee;
    public AudioClip worstHee;
    public AudioClip soso;
    AudioSource aud;
    bool bAudioPlay = false;

    void Start()
    {
        this.aud = GetComponent<AudioSource>();

        this.talk = GameObject.Find("talk");
        this.Talk = GameObject.Find("Talk");

        this.heejo0 = GameObject.Find("heejo0");
        this.heejo1 = GameObject.Find("heejo1");
        this.heejo2 = GameObject.Find("heejo2");

        totalPrice = HeeJoCupSizeDirector.instance.price + HeeJoLiquidDirector.instance.price + HeeJoSyrupScene.instance.price + HeeJoShotDirector.instance.price;
        Debug.Log(totalPrice);

    }


    void Update()
    {
        if (totalPrice == 4000)
        {
            this.heejo1.transform.localScale = new Vector3(1, 1, 1);
            this.talk.transform.localScale = new Vector3(0.8f, 0.8f, 1);
            this.Talk.GetComponent<Text>().text = "¾î? ¸ÀÀÖ´Ù.";

            if (bAudioPlay == false)
            {
                bAudioPlay = true;
                this.aud.PlayOneShot(this.smileSE);
                this.aud.PlayOneShot(this.bestHee);
            }
        }
        else if (totalPrice == 3000)
        {
            this.heejo0.transform.localScale = new Vector3(1, 1, 1);
            this.talk.transform.localScale = new Vector3(0.8f, 0.8f, 1);
            this.Talk.GetComponent<Text>().text = "À½... ¸ÔÀ»¸¸ ÇÏ³×.";

            if (bAudioPlay == false)
            {
                bAudioPlay = true;
                this.aud.PlayOneShot(this.soso);
            }
        }
        else
        {
            this.heejo2.transform.localScale = new Vector3(1, 1, 1);
            this.talk.transform.localScale = new Vector3(0.8f, 0.8f, 1);
            this.Talk.GetComponent<Text>().text = "¹¹¾ß! Æ¡.";

            if (bAudioPlay == false)
            {
                bAudioPlay = true;
                this.aud.PlayOneShot(this.angrySE);
                this.aud.PlayOneShot(this.worstHee);
            }
        }


        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.talk.transform.localScale = new Vector3(0, 0, 0);
            this.Talk.GetComponent<Text>().text = "";

            if (totalPrice == 4000)
                this.heejo1.transform.Translate(0.07f, 0, 0);
            else if (totalPrice == 3000)
                this.heejo0.transform.Translate(0.07f, 0, 0);
            else
                this.heejo2.transform.Translate(0.07f, 0, 0);

            if (this.heejo0.transform.position.x > 11.0f || this.heejo1.transform.position.x > 11.0f || this.heejo2.transform.position.x > 11.0f)
            {
                Debug.Log(InitialDirector.instance.totalsCount);

                if (InitialDirector.instance.totalsCount == 4)
                    SceneManager.LoadScene("Initial2Scene");
                else
                    SceneManager.LoadScene("JiHyeScene");
            }

        }

    }
}
