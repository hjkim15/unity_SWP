using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;
using TMPro;

public class commuteGameDirector2 : MonoBehaviour
{
    public float maxtime = 50.0f;

    GameObject timerText;
    GameObject timerSecondHand;
    GameObject Director;
    GameObject homeButton;

    public float time = 0.0f; //총 30초
    public bool timeflag = true;
    public float delta = 1.0f;
    float span = 1.0f; //1초에 6도씩 돌아감.
    float amount = 0;
    // Start is called before the first frame update
    void Start()
    {
        this.timerText = GameObject.Find("Time");
        this.timerSecondHand = GameObject.Find("clock2"); //초침
        this.Director = GameObject.Find("clock3");
        this.time = GameObject.Find("gameobject").GetComponent<commuteGameObject>().time;
        this.timerSecondHand.transform.Rotate(0, 0, -(90 - this.time) * 4);
        this.amount = (90 - this.time) * 4;
        this.homeButton = GameObject.Find("homeButton");
        homeButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (timeflag)
        {
            this.time -= Time.deltaTime;
            this.timerText.GetComponent<Text>().text = this.time.ToString("F0"); //시간 디지털 숫자로 출력
            this.delta += Time.deltaTime;
        }
        if (this.delta > this.span)
        { //초침 회전. 1초 지날 때마다 -12도씩 시계 방향으로 회전. 
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
            /*            Debug.Log("시간 다 됨.");
            */
            GameObject.Find("gameover").GetComponent<TextMeshProUGUI>().text = "TIME OVER";
            this.homeButton.SetActive(true);
            //GameObject.Find("homeButton").SetActive(true);
            //Invoke("gameOver", 5.0f);
            Time.timeScale = 0;
        }
    }
    //public void homeButton()
    //{
    //    SceneManager.LoadScene("calendarScene");
    //}
}
