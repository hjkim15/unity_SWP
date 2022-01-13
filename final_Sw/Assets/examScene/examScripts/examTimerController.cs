using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.EventSystems;

public class examTimerController : MonoBehaviour
{
    GameObject timerText;
    GameObject timerSecondHand;
    examTestController Director;
    GameObject libSit;
    GameObject itemList;
    // examResultController endResult;

    float timeLimit = 30.0f;
    float delta = 1;
    float span = 1.0f; //1초에 12도씩 돌아감.
    bool stop = false;
    bool timeOver = false;
    int leftLibSit = 0;
    bool blinkT = false;

    GameObject background;
    GameObject rslt; 
    GameObject result;
    AudioSource aud;
    public AudioClip WinSound;
    public AudioClip FailSound;
   // public AudioClip ticktock;

    int timeLeft;
    int sitLeft;
    string[] item404;
    bool found = true;
    bool play = true;
    string itlist;

    GameObject homeButton;


    void finResult(float t, int s, string[] l){
        Debug.Log("1");
        timeLeft = (int)t;
        sitLeft = (30-s)*2;
        item404 = l;
        itlist = "";

        PlayerPrefs.SetInt("ExamR", timeLeft);

        for(int i =0;i<item404.Length; i++){                    
            itlist += this.item404[i] + "  ";
            if(item404[i]==null)
                this.found = false;
        }
        
        result.SetActive(true);
        
        background.GetComponent<AudioSource>().Stop();
       // gameObject.GetComponent<AudioSource>().Stop();
        if(play){
            if(found){
                aud.PlayOneShot(WinSound);
                PlayerPrefs.SetString("ExamRP", "P");
            }
            else{
                aud.PlayOneShot(FailSound);
                PlayerPrefs.SetString("ExamRP", "NP");
            }
            play = false;
        }
            rslt.GetComponent<Text>().text = "남은 시간: " + this.timeLeft.ToString() + "초\n" 
                                           + "남은 좌석: " + this.sitLeft.ToString() + " \n"
                                           + "찾은 아이템: " + itlist
                                            + "\n";
        homeButton.SetActive(true);
    }


    void Start()
    {
        this.timerText = GameObject.Find("Time");
        this.timerSecondHand = GameObject.Find("secHand");
        this.Director= GameObject.Find("testDirector").GetComponent<examTestController>();
        this.libSit = GameObject.Find("libSit");
        // this.endResult = GameObject.Find("endRslt").GetComponent<examResultController>();
        this.result = GameObject.Find("endResult");
        this.rslt = GameObject.Find("endResultText");
        this.background = GameObject.Find("background_exam");
        this.aud = GameObject.Find("Time").GetComponent<AudioSource>();
        result.SetActive(false);
        StartCoroutine (blickText());
        this.homeButton = GameObject.Find("homeButton");
        homeButton.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if(!this.timeOver && !this.stop){  //물건 남은 시간동안 찾는 중
 
            this.timeLimit -= Time.deltaTime;
            this.delta += Time.deltaTime;
            if(this.delta>this.span){ //초침 회전. 1초 지날 때마다 -12도씩 시계 방향으로 회전. 
                this.delta = 0;
                timerSecondHand.transform.Rotate(0,0,-12);
                libSit.GetComponent<examLibSitController>().OccupySit(this.leftLibSit);
                this.leftLibSit++;                
            }

            if(this.timeLimit<=10.0f && this.timeLimit>0.0f){ //시간 10초 이하일 때 
                this.timerText.GetComponent<Text>().color = Color.red;
                this.blinkT = true; 
                //aud.Play(ticktock); 
            }
        }
        else{
            finResult(this.timeLimit, this.leftLibSit, Director.GetFoundItem());
            Time.timeScale=0;
        }

        if(this.timeLimit < 0.01f){ //시간 초과 시
                this.timeOver = true;
                this.Director.isTimeOver();
                this.timerText.GetComponent<Text>().text = ("0");
                Time.timeScale=0;
            }
        
    }

    IEnumerator blickText(){
        while(true){ //https://sosohanbox.tistory.com/159
            if(this.blinkT){
                this.timerText.GetComponent<Text>().text = " ";
                //aud.PlayOneShot(ticktock);
                //gameObject.GetComponent<AudioSource>().Play();
                }

            yield return new WaitForSeconds(0.5f);
            this.timerText.GetComponent<Text>().text = this.timeLimit.ToString("F0");
            yield return new WaitForSeconds(0.5f);
        }
        
    }

    public void foundAllItem(){
        this.stop = true;
    }

    public void increaseTime(){
        if(this.timeLimit <25){
            this.timeLimit += 5;
            this.timerSecondHand.transform.Rotate(0,0,60);
            this.leftLibSit -=5;
        }
        else{
            this.timeLimit = 30;
            this.timerSecondHand.transform.rotation = Quaternion.Euler(0,0,0);
            this.leftLibSit=0;
        }
    }
}
