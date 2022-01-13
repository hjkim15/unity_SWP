using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AfterHongDirector : MonoBehaviour
{
    public static AfterHongDirector instance = null;

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
    GameObject hong0;
    GameObject hong1;
    GameObject hong2;
    GameObject talk;
    GameObject Talk;

    float delta = 0;
    float span = 2.0f;

    public AudioClip smileSE;
    public AudioClip angrySE;
    public AudioClip bestHong;
    public AudioClip sosoHong;
    public AudioClip worstHong;
    AudioSource aud;
    bool bAudioPlay = false;

    void Start()
    {
        this.aud = GetComponent<AudioSource>();

        this.talk = GameObject.Find("talk");
        this.Talk = GameObject.Find("Talk");

        this.hong0 = GameObject.Find("hong0");
        this.hong1 = GameObject.Find("hong1");
        this.hong2 = GameObject.Find("hong2");

        totalPrice = HongCupSizeDirector.instance.price + HongLiquidDirector.instance.price + HongSyrupDirector.instance.price + HongShotDirector.instance.price +
                     HongToppingDirector.instance.price + HongCreamDirector.instance.price;
        Debug.Log(totalPrice);
    }


    void Update()
    {
        if (totalPrice == 6000)
        {
            this.hong1.transform.localScale = new Vector3(1, 1, 1);
            this.talk.transform.localScale = new Vector3(0.8f, 0.8f, 1);
            this.Talk.GetComponent<Text>().text = "너무 맛있어요. 잘만드셨네요.";

            if (bAudioPlay == false)
            {
                bAudioPlay = true;
                this.aud.PlayOneShot(this.smileSE);
                this.aud.PlayOneShot(this.bestHong);
            }
        }
        else if (totalPrice == 5000)
        {
            this.hong0.transform.localScale = new Vector3(1, 1, 1);
            this.talk.transform.localScale = new Vector3(0.8f, 0.8f, 1);
            this.Talk.GetComponent<Text>().text = "먹을만하네요.";

            if (bAudioPlay == false)
            {
                bAudioPlay = true;
                this.aud.PlayOneShot(this.sosoHong);
            }
        }
        else
        {
            this.hong2.transform.localScale = new Vector3(1, 1, 1);
            this.talk.transform.localScale = new Vector3(0.8f, 0.8f, 1);
            this.Talk.GetComponent<Text>().text = "아니 커피를 이렇게 만들면 안되지.";

            if (bAudioPlay == false)
            {
                bAudioPlay = true;
                this.aud.PlayOneShot(this.worstHong);
                this.aud.PlayOneShot(this.angrySE);
            }
        }


        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.talk.transform.localScale = new Vector3(0, 0, 0);
            this.Talk.GetComponent<Text>().text = "";

            if (totalPrice == 6000)
                this.hong1.transform.Translate(0.07f, 0, 0);
            else if (totalPrice == 5000)
                this.hong0.transform.Translate(0.07f, 0, 0);
            else
                this.hong2.transform.Translate(0.07f, 0, 0);

            if (this.hong0.transform.position.x > 11.0f || this.hong1.transform.position.x > 11.0f || this.hong2.transform.position.x > 11.0f)
            {
                if (Initial2Director.instance.totalpCount == 3)
                    SceneManager.LoadScene("AlbaScene");
                else
                    SceneManager.LoadScene("KimScene");
            }

        }

    }
}
