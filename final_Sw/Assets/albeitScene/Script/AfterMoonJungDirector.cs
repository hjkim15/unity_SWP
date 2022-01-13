using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AfterMoonJungDirector : MonoBehaviour
{
    public static AfterMoonJungDirector instance = null;

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
    GameObject moonjung0;
    GameObject moonjung1;
    GameObject moonjung2;
    GameObject talk;
    GameObject Talk;

    float delta = 0;
    float span = 2.0f;

    public AudioClip smileSE;
    public AudioClip angrySE;
    public AudioClip bestMoon;
    public AudioClip worstMoon;
    public AudioClip soso;
    AudioSource aud;
    bool bAudioPlay = false;

    void Start()
    {
        this.aud = GetComponent<AudioSource>();

        this.talk = GameObject.Find("talk");
        this.Talk = GameObject.Find("Talk");

        this.moonjung0 = GameObject.Find("moonjung0");
        this.moonjung1 = GameObject.Find("moonjung1");
        this.moonjung2 = GameObject.Find("moonjung2");

        totalPrice = MoonJungCupSizeDirector.instance.price + MoonJungLiquidDirector.instance.price + MoonJungSyrupDirector.instance.price + MoonJungShotDirector.instance.price;
        Debug.Log(totalPrice);
    }


    void Update()
    {
        if (totalPrice == 4000)
        {
            this.moonjung1.transform.localScale = new Vector3(1, 1, 1);
            this.talk.transform.localScale = new Vector3(0.8f, 0.8f, 1);
            this.Talk.GetComponent<Text>().text = "블루팟 커피 짱!";

            if (bAudioPlay == false)
            {
                bAudioPlay = true;
                this.aud.PlayOneShot(this.smileSE);
                this.aud.PlayOneShot(this.bestMoon);
            }
        }
        else if (totalPrice == 3000)
        {
            this.moonjung0.transform.localScale = new Vector3(1, 1, 1);
            this.talk.transform.localScale = new Vector3(0.8f, 0.8f, 1);
            this.Talk.GetComponent<Text>().text = "음... 먹을만하네.";

            if (bAudioPlay == false)
            {
                bAudioPlay = true;
                this.aud.PlayOneShot(this.soso);
            }
        }
        else
        {
            this.moonjung2.transform.localScale = new Vector3(1, 1, 1);
            this.talk.transform.localScale = new Vector3(0.8f, 0.8f, 1);
            this.Talk.GetComponent<Text>().text = "커피 맞아?";

            if (bAudioPlay == false)
            {
                bAudioPlay = true;
                this.aud.PlayOneShot(this.angrySE);
                this.aud.PlayOneShot(this.worstMoon);
            }
        }


        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.talk.transform.localScale = new Vector3(0, 0, 0);
            this.Talk.GetComponent<Text>().text = "";

            if (totalPrice == 4000)
                this.moonjung1.transform.Translate(0.07f, 0, 0);
            else if (totalPrice == 3000)
                this.moonjung0.transform.Translate(0.07f, 0, 0);
            else
                this.moonjung2.transform.Translate(0.07f, 0, 0);

            if (this.moonjung0.transform.position.x > 11.0f || this.moonjung1.transform.position.x > 11.0f || this.moonjung2.transform.position.x > 11.0f)
            {
                Debug.Log(InitialDirector.instance.totalsCount);

                if (InitialDirector.instance.totalsCount == 4)
                    SceneManager.LoadScene("Initial2Scene");
                else
                    SceneManager.LoadScene("DoYeonScene");
            }

        }

    }
}
