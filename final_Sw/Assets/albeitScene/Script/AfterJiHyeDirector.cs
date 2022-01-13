using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AfterJiHyeDirector : MonoBehaviour
{
    public static AfterJiHyeDirector instance = null;

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
    GameObject jihye0;
    GameObject jihye1;
    GameObject jihye2;
    GameObject talk;
    GameObject Talk;

    float delta = 0;
    float span = 2.0f;

    public AudioClip smileSE;
    public AudioClip angrySE;
    public AudioClip bestJi;
    public AudioClip soso;
    public AudioClip worstJi;
    AudioSource aud;
    bool bAudioPlay = false;

    void Start()
    {
        this.aud = GetComponent<AudioSource>();

        this.talk = GameObject.Find("talk");
        this.Talk = GameObject.Find("Talk");

        this.jihye0 = GameObject.Find("jihye0");
        this.jihye1 = GameObject.Find("jihye1");
        this.jihye2 = GameObject.Find("jihye2");

        totalPrice = JiHyeCupSizeDirector.instance.price + JiHyeLiquidDirector.instance.price + JiHyeSyrupDirector.instance.price + JiHyeShotDirector.instance.price;
        Debug.Log(totalPrice);
    }


    void Update()
    {
        if (totalPrice == 4000)
        {
            this.jihye1.transform.localScale = new Vector3(1, 1, 1);
            this.talk.transform.localScale = new Vector3(0.8f, 0.8f, 1);
            this.Talk.GetComponent<Text>().text = "Çæ! ¸ÀÀÖ¾î!";

            if (bAudioPlay == false)
            {
                bAudioPlay = true;
                this.aud.PlayOneShot(this.smileSE);
                this.aud.PlayOneShot(this.bestJi);
            }
        }
        else if (totalPrice == 3000)
        {
            this.jihye0.transform.localScale = new Vector3(1, 1, 1);
            this.talk.transform.localScale = new Vector3(0.8f, 0.8f, 1);
            this.Talk.GetComponent<Text>().text = "À½...¸ÔÀ»¸¸ÇÏ³×.";

            if (bAudioPlay == false)
            {
                bAudioPlay = true;
                this.aud.PlayOneShot(this.soso);
            }
        }
        else
        {
            this.jihye2.transform.localScale = new Vector3(1, 1, 1);
            this.talk.transform.localScale = new Vector3(0.8f, 0.8f, 1);
            this.Talk.GetComponent<Text>().text = "´Ù½Å ¾È¿Í!";

            if (bAudioPlay == false)
            {
                bAudioPlay = true;
                this.aud.PlayOneShot(this.worstJi);
                this.aud.PlayOneShot(this.angrySE);
            }
        }


        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.talk.transform.localScale = new Vector3(0, 0, 0);
            this.Talk.GetComponent<Text>().text = "";

            if (totalPrice == 4000)
                this.jihye1.transform.Translate(0.07f, 0, 0);
            else if (totalPrice == 3000)
                this.jihye0.transform.Translate(0.07f, 0, 0);
            else
                this.jihye2.transform.Translate(0.07f, 0, 0);

            if (this.jihye0.transform.position.x > 11.0f || this.jihye1.transform.position.x > 11.0f || this.jihye2.transform.position.x > 11.0f)
            {
                Debug.Log(InitialDirector.instance.totalsCount);

                if (InitialDirector.instance.totalsCount == 4)
                    SceneManager.LoadScene("Initial2Scene");
                else
                    SceneManager.LoadScene("MoonJungScene");
            }

        }

    }
}
