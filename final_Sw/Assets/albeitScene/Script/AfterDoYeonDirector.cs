using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AfterDoYeonDirector : MonoBehaviour
{
    public static AfterDoYeonDirector instance = null;

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
    public int totalsCount = 0;
    GameObject doyeon0;
    GameObject doyeon1;
    GameObject doyeon2;
    GameObject talk;
    GameObject Talk;

    float delta = 0;
    float span = 2.0f;

    public AudioClip smileSE;
    public AudioClip angrySE;
    public AudioClip bestDo;
    public AudioClip worstDo;
    public AudioClip soso;
    AudioSource aud;
    bool bAudioPlay = false;

    void Start()
    {
        this.aud = GetComponent<AudioSource>();

        this.talk = GameObject.Find("talk");
        this.Talk = GameObject.Find("Talk");

        this.doyeon0 = GameObject.Find("doyeon0");
        this.doyeon1 = GameObject.Find("doyeon1");
        this.doyeon2 = GameObject.Find("doyeon2");

        totalPrice = DoYeonCupSizeDirector.instance.price + DoYeonLiquidDirector.instance.price + DoYeonSyrupDirector.instance.price + DoYeonShotDirector.instance.price;
        Debug.Log(totalPrice);
    }


    void Update()
    {
        if (totalPrice == 4000)
        {
            this.doyeon1.transform.localScale = new Vector3(1, 1, 1);
            this.talk.transform.localScale = new Vector3(0.8f, 0.8f, 1);
            this.Talk.GetComponent<Text>().text = "√÷∞Ì¿« ∏¿¿Ãæﬂ!";

            if (bAudioPlay == false)
            {
                bAudioPlay = true;
                this.aud.PlayOneShot(this.smileSE);
                this.aud.PlayOneShot(this.bestDo);
            }
        }
        else if (totalPrice == 3000)
        {
            this.doyeon0.transform.localScale = new Vector3(1, 1, 1);
            this.talk.transform.localScale = new Vector3(0.8f, 0.8f, 1);
            this.Talk.GetComponent<Text>().text = "¿Ω... ∏‘¿ª∏∏«œ≥◊.";

            if (bAudioPlay == false)
            {
                bAudioPlay = true;
                this.aud.PlayOneShot(this.soso);
            }
        }
        else
        {
            this.doyeon2.transform.localScale = new Vector3(1, 1, 1);
            this.talk.transform.localScale = new Vector3(0.8f, 0.8f, 1);
            this.Talk.GetComponent<Text>().text = "√÷æ«¿« ∏¿¿Ãæﬂ!";

            if (bAudioPlay == false)
            {
                bAudioPlay = true;
                this.aud.PlayOneShot(this.angrySE);
                this.aud.PlayOneShot(this.worstDo);
            }
        }


        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.talk.transform.localScale = new Vector3(0, 0, 0);
            this.Talk.GetComponent<Text>().text = "";

            if (totalPrice == 4000)
                this.doyeon1.transform.Translate(0.07f, 0, 0);
            else if (totalPrice == 3000)
                this.doyeon0.transform.Translate(0.07f, 0, 0);
            else
                this.doyeon2.transform.Translate(0.07f, 0, 0);

            if (this.doyeon0.transform.position.x > 11.0f || this.doyeon1.transform.position.x > 11.0f || this.doyeon2.transform.position.x > 11.0f)
            {
                Debug.Log(InitialDirector.instance.totalsCount);

                if (InitialDirector.instance.totalsCount == 4)
                    SceneManager.LoadScene("Initial2Scene");
                else
                    SceneManager.LoadScene("HeeJoScene");
            }

        }

    }
}
