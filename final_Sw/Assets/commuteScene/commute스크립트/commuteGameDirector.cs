using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class commuteGameDirector : MonoBehaviour
{
    GameObject speedUI;
    GameObject cause;
    public float maxtime = 90.0f;
    public float speed;
    public string[] comment = new string[8];
    public int index = 3; //comment의 인덱스 값

    GameObject timerText;
    GameObject timerSecondHand;
    GameObject Director;
    GameObject homeButton;
    public float time = 90.0f; //총 90초
    float delta = 0;
    float span = 1.0f; //1초에 4도씩 돌아감.
    float amount = 0;


    // Start is called before the first frame update
    void Start()
    {
        this.speedUI = GameObject.Find("speedUI");
        this.cause = GameObject.Find("cause");
        this.time = 90.0f; //90초로 다시 바꿔야
        comment[0] = "길이 너무 좁아요";
        comment[1] = "사람이 너무 많아요";
        comment[2] = "길이 너무 가파라요";
        comment[3] = "";
        comment[4] = "직진 추천해요! 우회전하면 사람이 너무 많을 거에요";
        comment[5] = "좌회전 추천해요! 직진하면 사람이 너무 많을 거에요";
        comment[6] = "오르막길이라 힘들어도 이쪽 길이 빨라요";
        comment[7] = "우회전으로 가세요";

        this.timerText = GameObject.Find("Time");
        this.timerSecondHand = GameObject.Find("clock2"); //초침
        this.Director = GameObject.Find("clock3");
        this.homeButton = GameObject.Find("homeButton");
        homeButton.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        speed = GameObject.Find("character").GetComponent<commuteController>().moveSpeed;
        speedUI.GetComponent<Text>().text = "Speed: " + (speed * 10).ToString("F0") + " m/s";
        if (index == 3) cause.GetComponent<Text>().text = "수정님 파이팅!";
        else cause.GetComponent<Text>().text = "수정님! " + comment[index];


        this.time -= Time.deltaTime;
        this.timerText.GetComponent<Text>().text = this.time.ToString("F0"); //시간 디지털 숫자로 출력
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        { //초침 회전. 1초 지날 때마다 -4도씩 시계 방향으로 회전. 
            this.delta = 0;
            timerSecondHand.transform.Rotate(0, 0, -4.0f);
            amount += 4.0f;
            Director.GetComponent<Image>().fillAmount = amount / 360.0f;
        }
        if (this.time < 10.0f && this.time > 0.0f)
        { //시간 10초 이하일 때 
            this.timerText.GetComponent<Text>().color = Color.red;
        }



        if (this.time < 0)
        { //시간 초과 시
          //Debug.Log("시간 다 됨.");
            Time.timeScale = 0;
            GameObject.Find("gameover").GetComponent<TextMeshProUGUI>().text = "TIME OVER";
            this.homeButton.SetActive(true);
            //Invoke("gameOver", 5.0f);
            //this.timeOver = true;
            //this.Director.GetComponent<examTestController>().isTimeOver();

        }
    }

    //void gameOver()
    //{
    //SceneManager.LoadScene("calendarScene");
    //}
    public void home()
    {
        PlayerPrefs.SetFloat("CommuteR", this.time);
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

}
