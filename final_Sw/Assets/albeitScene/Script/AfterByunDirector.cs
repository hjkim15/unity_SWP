using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AfterByunDirector : MonoBehaviour
{
    public static AfterByunDirector instance = null;

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
    GameObject byun0;
    GameObject byun1;
    GameObject byun2;
    GameObject talk;
    GameObject Talk;

    float delta = 0;
    float span = 2.0f;

    public AudioClip smileSE;
    public AudioClip angrySE;
    public AudioClip bestByun;
    public AudioClip sosoByun;
    public AudioClip worstByun;
    AudioSource aud;
    bool bAudioPlay = false;

    void Start()
    {
        this.aud = GetComponent<AudioSource>();

        this.talk = GameObject.Find("talk");
        this.Talk = GameObject.Find("Talk");

        this.byun0 = GameObject.Find("byun0");
        this.byun1 = GameObject.Find("byun1");
        this.byun2 = GameObject.Find("byun2");

        totalPrice = ByunCupSizeDirector.instance.price + ByunLiquidDirector.instance.price + ByunSyrupDirector.instance.price + ByunShotDirector.instance.price +
                     ByunToppingDirector.instance.price + ByunCreamDirector.instance.price;
        Debug.Log(totalPrice);
    }


    void Update()
    {
        if (totalPrice == 6000)
        {
            this.byun1.transform.localScale = new Vector3(1, 1, 1);
            this.talk.transform.localScale = new Vector3(0.8f, 0.8f, 1);
            this.Talk.GetComponent<Text>().text = "너무 맛있다 베이비!";

            if (bAudioPlay == false)
            {
                bAudioPlay = true;
                this.aud.PlayOneShot(this.bestByun);
                this.aud.PlayOneShot(this.smileSE);
            }
        }
        else if (totalPrice == 5000)
        {
            this.byun0.transform.localScale = new Vector3(1, 1, 1);
            this.talk.transform.localScale = new Vector3(0.8f, 0.8f, 1);
            this.Talk.GetComponent<Text>().text = "그저그런 커피맛이네.";

            if (bAudioPlay == false)
            {
                bAudioPlay = true;
                this.aud.PlayOneShot(this.sosoByun);
            }
        }
        else
        {
            this.byun2.transform.localScale = new Vector3(1, 1, 1);
            this.talk.transform.localScale = new Vector3(0.8f, 0.8f, 1);
            this.Talk.GetComponent<Text>().text = "최악이야!";

            if (bAudioPlay == false)
            {
                bAudioPlay = true;
                this.aud.PlayOneShot(this.worstByun);
                this.aud.PlayOneShot(this.angrySE);
            }
        }


        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.talk.transform.localScale = new Vector3(0, 0, 0);
            this.Talk.GetComponent<Text>().text = "";

            if (totalPrice == 6000)
                this.byun1.transform.Translate(0.07f, 0, 0);
            else if (totalPrice == 5000)
                this.byun0.transform.Translate(0.07f, 0, 0);
            else
                this.byun2.transform.Translate(0.07f, 0, 0);

            if (this.byun0.transform.position.x > 11.0f || this.byun1.transform.position.x > 11.0f || this.byun2.transform.position.x > 11.0f)
            {
                if (Initial2Director.instance.totalpCount == 3)
                    SceneManager.LoadScene("AlbaScene");
                else
                    SceneManager.LoadScene("HongScene");
            }

        }

    }
}
