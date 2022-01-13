using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JiHyeController : MonoBehaviour
{
    public static JiHyeController instance = null;

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

    GameObject receipt;
    GameObject talk;
    GameObject talkText;
    GameObject cupSizeText;
    GameObject liquidText;
    GameObject syrupText;
    GameObject shotText;
    public int cupSize;
    public int liquid;
    public int syrup;
    public int shot;
    float span = 10.0f;
    float delta = 0;

    public AudioClip usualJi;
    AudioSource aud;
    bool bAudioPlay = false;

    void Start()
    {
        this.receipt = GameObject.Find("receipt");
        this.talk = GameObject.Find("talk");
        this.talkText = GameObject.Find("Talk");
        this.cupSizeText = GameObject.Find("CupSize");
        this.liquidText = GameObject.Find("Liquid");
        this.syrupText = GameObject.Find("Syrup");
        this.shotText = GameObject.Find("Shot");
        cupSize = Random.Range(0, 3);
        liquid = Random.Range(0, 4);
        syrup = Random.Range(0, 3);
        shot = Random.Range(0, 3);

        this.aud = GetComponent<AudioSource>();
    }

    void Update()
    {

        transform.localScale = new Vector3(1, 1, 1);
        transform.Translate(0.01f, 0, 0);

        if (transform.position.x > 0)
        {
            transform.position = new Vector3(0, -0.1f, 0);
            receipt.transform.localScale = new Vector3(0.7f, 0.85f, 1);
            talk.transform.localScale = new Vector3(0.8f, 0.8f, 1);
            this.talkText.GetComponent<Text>().text = "최고의 커피! 기대할게요!";

            if (bAudioPlay == false)
            {
                bAudioPlay = true;
                this.aud.PlayOneShot(usualJi);
            }

            if (cupSize == 0)
                this.cupSizeText.GetComponent<Text>().text = "컵사이즈는 S";
            else if (cupSize == 1)
                this.cupSizeText.GetComponent<Text>().text = "컵사이즈는 M";
            else
                this.cupSizeText.GetComponent<Text>().text = "컵사이즈는 T";

            if (liquid == 0)
                this.liquidText.GetComponent<Text>().text = "무지방 우유";
            else if (liquid == 1)
                this.liquidText.GetComponent<Text>().text = "저지방 우유";
            else if (liquid == 2)
                this.liquidText.GetComponent<Text>().text = "차가운 물";
            else
                this.liquidText.GetComponent<Text>().text = "뜨거운 물";

            if (syrup == 0)
                this.syrupText.GetComponent<Text>().text = "바닐라 시럽";
            else if (syrup == 1)
                this.syrupText.GetComponent<Text>().text = "모카 시럽";
            else
                this.syrupText.GetComponent<Text>().text = "메이플 시럽";

            if (shot == 0)
                this.shotText.GetComponent<Text>().text = "샷 한번 추가";
            else if (shot == 1)
                this.shotText.GetComponent<Text>().text = "샷 두번 추가";
            else
                this.shotText.GetComponent<Text>().text = "샷 세번 추가";
        }

        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            transform.localScale = new Vector3(0, 0, 0);
            SceneManager.LoadScene("JiHyeCupSizeScene");

            Destroy(talkText);
            Destroy(cupSizeText);
            Destroy(liquidText);
            Destroy(shotText);
            Destroy(syrupText);
        }


    }   
}
