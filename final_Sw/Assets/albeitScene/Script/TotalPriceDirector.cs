using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TotalPriceDirector : MonoBehaviour
{
    public static TotalPriceDirector instance = null;

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

    public int price;

    GameObject totalPrice;

    public AudioClip ending;
    AudioSource aud;

    void Start()
    {
        this.aud = GetComponent<AudioSource>();
        this.aud.PlayOneShot(this.ending);

        this.totalPrice = GameObject.Find("TotalPrice");

        price = AfterDoYeonDirector.instance.totalPrice + AfterHeeJoDirector.instance.totalPrice + AfterJiHyeDirector.instance.totalPrice + AfterMoonJungDirector.instance.totalPrice
                + AfterByunDirector.instance.totalPrice + AfterHongDirector.instance.totalPrice + AfterKimDirector.instance.totalPrice;

        this.totalPrice.GetComponent<Text>().text = "*" + price;
    }

    void Update()
    {
        
    }

    public void SceneChange()
    {
        PlayerPrefs.SetInt("AlbeitR", this.price); //알바씬 결과값 저장.
        if (PlayerPrefs.GetInt("retry") == 0)
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().saveCalDate(21);
            SceneManager.LoadScene("calendarScene");
        }
        else if(PlayerPrefs.GetInt("retry") == 1)
        {
            SceneManager.LoadScene("endScene");
        }
    }
}
