using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class commuteCameraController2 : MonoBehaviour
{

    GameObject player;
    public int flag = 0;//0: player , 1: picture1, 2:picture2, 3:picture3
    public float time2 = 0;
    float time3 = 0;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("move1");
        //GameObject.Find("result_message").GetComponent<Text>().text = "";
        this.time2 = 90 - GameObject.Find("GameDirector").GetComponent<commuteGameDirector2>().time;
    }

    // Update is called once per frame
    void Update()
    {

        if (flag == 0)
        {
            transform.position = new Vector3(61.0f, 33.0f, -10.0f);
        }
        else if (flag == 1)
        {
            transform.position = new Vector3(-167.0f, 220.0f, -10.0f);
            GameObject.Find("GameDirector").GetComponent<commuteGameDirector2>().timeflag = false;
            GameObject.Find("GameDirector").GetComponent<commuteGameDirector2>().delta = 0;
            GameObject.Find("move1").GetComponent<commuteController2>().playerflag = false;
            Invoke("comeback", 5.0f);
        }
        else if (flag == 2)
        {
            transform.position = new Vector3(120.0f, 229.0f, -10.0f);
            GameObject.Find("GameDirector").GetComponent<commuteGameDirector2>().timeflag = false;
            GameObject.Find("GameDirector").GetComponent<commuteGameDirector2>().delta = 0;
            GameObject.Find("move1").GetComponent<commuteController2>().playerflag = false;
            Invoke("comeback", 5.0f);
        }
        else if (flag == 3)
        {
            transform.position = new Vector3(397.70f, 232.97f, -10.0f);
            GameObject.Find("GameDirector").GetComponent<commuteGameDirector2>().timeflag = false;
            GameObject.Find("GameDirector").GetComponent<commuteGameDirector2>().delta = 0.0f;
            GameObject.Find("move1").GetComponent<commuteController2>().playerflag = false;
            Invoke("gameSuccess", 5.5f);
        }
    }

    void gameSuccess()
    {
        this.time3 = GameObject.Find("GameDirector").GetComponent<commuteGameDirector2>().time;
        GameObject.Find("GameDirector").GetComponent<commuteGameDirector2>().timeflag = false;
        GameObject.Find("gameover").GetComponent<TextMeshProUGUI>().text = "SUCCESS! \n" + time3.ToString("F0") + " SECONDS LEFT";
        //결과 시간값 넘겨줌.
        Invoke("gameOver", 5.0f);
        //SceneManager.LoadScene("gameover");
    }

    public void gameOver()
    {
        //time3 = GameObject.Find("GameDirector").GetComponent<commuteGameDirector2>().time;
        PlayerPrefs.SetFloat("CommuteR", this.time3);

        if (PlayerPrefs.GetInt("retry") == 0)
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().saveCalDate(25);
            SceneManager.LoadScene("calendarScene");
        }
        else if (PlayerPrefs.GetInt("retry") == 1)
        {
            SceneManager.LoadScene("endScene");
        }

    }

    void comeback()
    {
        flag = 0;
        GameObject.Find("GameDirector").GetComponent<commuteGameDirector2>().timeflag = true;
        GameObject.Find("move1").GetComponent<commuteController2>().playerflag = true;
    }
}
