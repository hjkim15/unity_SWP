using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AfterKimDirector : MonoBehaviour
{
    public static AfterKimDirector instance = null;

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
    GameObject kim0;
    GameObject kim1;
    GameObject kim2;
    GameObject talk;
    GameObject Talk;

    float delta = 0;
    float span = 2.0f;

    public AudioClip smileSE;
    public AudioClip angrySE;
    public AudioClip bestKim;
    public AudioClip sosoKim;
    public AudioClip worstKim;
    AudioSource aud;
    bool bAudioPlay = false;

    void Start()
    {
        this.aud = GetComponent<AudioSource>();

        this.talk = GameObject.Find("talk");
        this.Talk = GameObject.Find("Talk");

        this.kim0 = GameObject.Find("kim0");
        this.kim1 = GameObject.Find("kim1");
        this.kim2 = GameObject.Find("kim2");

        totalPrice = KimCupSizeDirector.instance.price + KimLiquidDirector.instance.price + KimSyrupDirector.instance.price + KimShotDirector.instance.price +
                     KimToppingDirector.instance.price + KimCreamDirector.instance.price;
        Debug.Log(totalPrice);
    }


    void Update()
    {
        if (totalPrice == 6000)
        {
            this.kim1.transform.localScale = new Vector3(1, 1, 1);
            this.talk.transform.localScale = new Vector3(0.8f, 0.8f, 1);
            this.Talk.GetComponent<Text>().text = "너무 맛있어요. 고생많으셨어요!";

            if (bAudioPlay == false)
            {
                bAudioPlay = true;
                this.aud.PlayOneShot(this.smileSE);
                this.aud.PlayOneShot(this.bestKim);
            }
        }
        else if (totalPrice == 5000)
        {
            this.kim0.transform.localScale = new Vector3(1, 1, 1);
            this.talk.transform.localScale = new Vector3(0.8f, 0.8f, 1);
            this.Talk.GetComponent<Text>().text = "먹을만하네요.";

            if (bAudioPlay == false)
            {
                bAudioPlay = true;
                this.aud.PlayOneShot(this.sosoKim);
            }
        }
        else
        {
            this.kim2.transform.localScale = new Vector3(1, 1, 1);
            this.talk.transform.localScale = new Vector3(0.8f, 0.8f, 1);
            this.Talk.GetComponent<Text>().text = "커피맛이 형편없어.";

            if (bAudioPlay == false)
            {
                bAudioPlay = true;
                this.aud.PlayOneShot(this.worstKim);
                this.aud.PlayOneShot(this.angrySE);
            }
        }


        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.talk.transform.localScale = new Vector3(0, 0, 0);
            this.Talk.GetComponent<Text>().text = "";

            if (totalPrice == 6000)
                this.kim1.transform.Translate(0.07f, 0, 0);
            else if (totalPrice == 5000)
                this.kim0.transform.Translate(0.07f, 0, 0);
            else
                this.kim2.transform.Translate(0.07f, 0, 0);

            if (this.kim0.transform.position.x > 11.0f || this.kim1.transform.position.x > 11.0f || this.kim2.transform.position.x > 11.0f)
            {
                if (Initial2Director.instance.totalpCount == 3)
                    SceneManager.LoadScene("AlbaScene");
                else
                    SceneManager.LoadScene("ByunScene");
            }

        }

    }
}
