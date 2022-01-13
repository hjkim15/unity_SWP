using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class calendarDateController : MonoBehaviour
{

    GameObject[] dates = new GameObject[35];
    GameObject schedule;
    int month = 3; //어떤 씬 연결인지. 3월로 바꾸게 되면
    int today = 1;
    int startD = 0;
    int monthD = 0;
    GameObject dateL;
    GameObject monthL;
     
    GameObject[] Buttons = new GameObject[8];
    GameObject GameManager;
    

    // Start is called before the first frame update
    void Start()
    { 
        for(int i=0;i<35;i++){ //날짜 칸 배열에 gameobject로 받는 부분
            dates[i] = GameObject.Find(i.ToString());
        }
        schedule = GameObject.Find("schedule");
        dateL = GameObject.Find("date");
        monthL = GameObject.Find("month");
        Time.timeScale = 1; //각 씬마다 멈췄던 시간 다시 흐르게

        for (int i =  0; i < 8; i++){
            this.Buttons[i] = GameObject.Find(("Button" + i.ToString()));
            this.Buttons[i].SetActive(false);
        }

        this.today = GameObject.Find("GameManager").GetComponent<GameManager>().loadCalDate();
        getDate(this.today);
    }

    // Update is called once per frame
    void Update()
    {
        //getMonth(); //이거랑
        //getSchedule(); //이거로 이제 씬 넘겨 받을 때 달이랑 날짜가 다를 테니까 다시 달력 일 세팅 하는 것. 
        // setCalendar();
        //getDate(/*어떤 날로 할지*/1); //함수 내 값에 따라 출력되는 거 다름.
        
    }

    void setCalendar() //달력 세팅. 
    {
        for (int i = this.startD; i < (this.startD + this.monthD); i++)
        {
            dates[i].GetComponent<Text>().text = (i - this.startD + 1).ToString();
        }
        dateL.GetComponent<Text>().text = this.today.ToString(); //왼쪽 큰 글씨 today's date 변경
        monthL.GetComponent<Text>().text = "2022.0" + this.month.ToString();

    }

    void setMonth(int t){ //달에 맞춰 달력 날짜 세팅
        this.month = t;
        switch(t){
            case 2:
                this.startD = 3;
                this.monthD = 28;
                break;
            case 3:
                this.startD = 3;
                this.monthD = 31;
                break;
            case 4:
                this.startD = 6;
                this.monthD = 30;
                break;
            case 5:
                this.startD = 1;
                this.monthD = 31;
                break;
            case 6:
                this.startD = 4;
                this.monthD = 30;
                break;
        }
    }

    void getDate(int d){
        this.today = d;
        switch (d)
        {
            case 1: //통학. 3/1. 3번
                setMonth(3);
                schedule.GetComponent<Text>().text = "개강";
                this.Buttons[0].SetActive(true);
                break;
            case 7: //알바. 4/7 12번
                setMonth(4);
                schedule.GetComponent<Text>().text = "알바";
                this.Buttons[1].SetActive(true);
                break;
            case 13: //시험. 6/13 16번
                setMonth(6);
                schedule.GetComponent<Text>().text = "기말고사";
                this.Buttons[2].SetActive(true);
                break;
            case 16: //수강. 2/16 18번
                setMonth(2);
                schedule.GetComponent<Text>().text = "수강신청";
                this.Buttons[3].SetActive(true);
                break;
            case 18: //오티. 2/18 20번
                setMonth(2);
                schedule.GetComponent<Text>().text = "신입생 오리엔테이션";
                this.Buttons[4].SetActive(true);
                break;
            case 21: //과제. 5/21 21번
                setMonth(5);
                schedule.GetComponent<Text>().text = "과제";
                this.Buttons[5].SetActive(true);
                break;
            case 23: //종강. 6/23 26번
                setMonth(6);
                schedule.GetComponent<Text>().text = "종강";
                this.Buttons[6].SetActive(true);
                break;
            case 25: //mt. 3/25  27번
                setMonth(3);
                schedule.GetComponent<Text>().text = "MT";
                this.Buttons[7].SetActive(true);
               // Debug.Log("이게 왜 출력되는걸까");
                break;

        }
        setCalendar();

    }
    
    //void getSchedule(){//값을 month말고 date으로 바꿔야. 각 이벤트 날로 입력.
    //    switch(this.today){
    //        case 1://통학. 3/1. 3번
                
    //            break;
    //        case 7://알바. 4/7 12번
                
    //            break;
    //        case 13://시험. 6/13 16번
                
    //            break;
    //        case 16: //수강. 2/16 18번
                
    //            break;
    //        case 18: //오티. 2/18 20번
                
    //            break;
    //        case 21: //과제. 5/21 21번
                
    //            break;
    //        case 23: //종강. 6/23 26번
                
    //            break;
    //        case 25: //mt. 3/25  27번
                
    //            break;
    //    }
    //}

}


