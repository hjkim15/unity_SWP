using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameDirector : MonoBehaviour
{
    GameObject timer;
    GameObject wait;
    GameObject alarm1;
    GameObject alarm2;
    GameObject scroll1;
    GameObject view1;
    GameObject view2;
    GameObject firstLabel;
    GameObject parent;
    GameObject count1;

    GameObject stName;

    public GameObject alarm3;
    public GameObject alarm4;
    public TMP_Text tex;
    public TMP_Text tex2;
    public TMP_Text front;
    public TMP_Text behind;
    public Button registerButton;
    public Button searchButton;
    public Slider bar;
    public Image imgPrefab;
    public GameObject HomeButton;

    public int hour;
    public int minute;
    public float seconds;
    int f = 0;
    int b = 0;
    float t = 0f;
    bool check = false;
    float connect = 0f;

    JsonClass json;
    Rbutton rbutton;

    public AudioSource aud;

    void Start()
    {
        this.stName = GameObject.Find("name");
        this.stName.GetComponent<TextMeshProUGUI>().text = (PlayerPrefs.GetString("Name") + " (" + PlayerPrefs.GetString("ID") + ") -로그아웃");

        this.timer = GameObject.Find("Time");
        this.wait = GameObject.Find("Panel");
        this.alarm1 = GameObject.Find("Panel1");
        this.alarm2 = GameObject.Find("Panel2");
        this.alarm3 = GameObject.Find("Panel3");
        this.alarm4 = GameObject.Find("Panel4");
        this.scroll1 = GameObject.Find("Scroll1");
        this.view1 = GameObject.Find("view1");
        this.view2 = GameObject.Find("view2");
        this.firstLabel = GameObject.Find("firstLabel");
        this.parent = GameObject.Find("Parent");
        this.count1 = GameObject.Find("count1");

        this.registerButton.onClick.AddListener(select);
        this.searchButton.onClick.AddListener(search);
        this.aud = GetComponent<AudioSource>();

        wait.SetActive(false);
        alarm1.SetActive(false);
        alarm2.SetActive(false);
        alarm3.SetActive(false);
        alarm4.SetActive(false);

        firstLabel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //시간 설정
        setTimer();

        //화면 선택
        if (Input.GetKeyDown(KeyCode.F5))
        {
            select();
        }

    }
    public void close()
    {
        this.alarm2.SetActive(false);
    }

    public void close1()
    {
        this.alarm1.SetActive(false);
    }


    void setTimer()
    {
        this.seconds += Time.deltaTime;

        this.timer.GetComponent<TextMeshProUGUI>().text = string.Format("{0:D2} : {1:D2} : {2:D2}", hour, minute, (int)seconds);

        if ((int)this.seconds > 59)
        {
            this.seconds = 0;
            this.minute++;
        }

        if (this.minute > 59)
        {
            this.minute = 0;
            this.hour++;

        }
        if (this.hour == 10 && this.minute == 0 && this.seconds >= 10)
            this.HomeButton.SetActive(true);
    }

    public void select()
    {
        //10시가 되면
        if (this.hour >= 10)
        {
            check = true;
            //과목, 개설강자과목, 검색 dropdown 부분 작동
            tex.text = "[2022학년도 1학기] 수강신청기간 : 2022-02-16 10:00 ~ 2022-02-18 19:00";
            firstLabel.SetActive(true);

            // 0이라면 바로 수강신청 연결
            if (seconds > 40) connect = 0;
            else connect = Random.Range(0, 2);

            if (connect == 0)
            {
                //화면 바로, or 1초 후 or 2초 후 뜨기.
                scroll1.SetActive(false);

                float invokeTime = Random.Range(1, 4);
                Invoke("OnInvoke", invokeTime);
            }
            else
            {
                view1.SetActive(false);
                view2.SetActive(false);
                //    count++;
                StartCoroutine(wait2());
            }

        }
        else {
            aud.Play();
            alarm1.SetActive(true);
        }
    }

    void OnInvoke()
    {
        scroll1.SetActive(true);
        view1.SetActive(true);
        view2.SetActive(true);
    }

    //접속대기 관련 실행 함수
    IEnumerator wait2()
    {
        wait.SetActive(true);

        if (this.seconds < 10) { t = Random.Range(10, 14); f = Random.Range(150, 201); b = 300 - f; }
        else if (this.seconds < 20) { t = Random.Range(7, 11); f = Random.Range(100, 151); b = 300 - f; }
        else if (this.seconds < 30) { t = Random.Range(4, 8); f = Random.Range(50, 101); b = 300 - f; }
        else if (this.seconds < 40) { t = Random.Range(1, 5); f = Random.Range(5, 51); b = 300 - f; }

        front.text = f.ToString();
        behind.text = b.ToString();

        bar.maxValue = t;

        for (int i = (int)t; i >= 0; i--)
        {
            tex2.text = "예상시간 : " + i.ToString() + "초";
            bar.value = Mathf.Abs(i - t) + 1;

            if (i == 1) { front.text = "1"; behind.text = "299"; }
            else if (i == 0)
            {
                front.text = "0";
                behind.text = "299";
                wait.SetActive(false);
                view1.SetActive(true);
                view2.SetActive(true);
            }
            else
            {
                f -= (i + Random.Range(1, 10));
                Mathf.Abs(f);
                b = Mathf.Abs(300 - f);
            }

            front.text = f.ToString();
            behind.text = b.ToString();

            yield return new WaitForSeconds(1.0f);
        }

    }

    //조회 버튼 눌렀을 때
    void search()
    {
        //10시 지나서 수강신청 -> 조회 버튼 눌렀을 시 json에 저장된 파일 가져와 화면 보여주기
        if ((this.hour >= 10) && (this.check == true))
        {
            if (parent.transform.childCount == 0)
            {
                json = GameObject.Find("director").GetComponent<JsonClass>();


                for (int i = 0; i < json.myList.school.Length; i++)
                {
                    //이미지들 생성
                    Image img = Instantiate(imgPrefab) as Image;
                    img.transform.SetParent(parent.transform);
                    img.transform.localScale = new Vector3(1, 1, 1);

                    //json에서 불러온 정보 tag 주기
                    img.tag = (i + 1).ToString();

                    //이미지 객체의 자식 오브젝트 설정
                    img.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = (i + 1).ToString();
                    img.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = json.myList.school[i].one;
                    img.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text = json.myList.school[i].two;
                    img.transform.GetChild(4).GetComponent<TextMeshProUGUI>().text = json.myList.school[i].three;
                    img.transform.GetChild(5).GetComponent<TextMeshProUGUI>().text = json.myList.school[i].four;
                    img.transform.GetChild(6).GetComponent<TextMeshProUGUI>().text = json.myList.school[i].five;
                    img.transform.GetChild(7).GetComponent<TextMeshProUGUI>().text = json.myList.school[i].six;
                    img.transform.GetChild(8).GetComponent<TextMeshProUGUI>().text = json.myList.school[i].seven;
                    img.transform.GetChild(9).GetComponent<TextMeshProUGUI>().text = json.myList.school[i].eight;
                    img.transform.GetChild(10).GetComponent<TextMeshProUGUI>().text = json.myList.school[i].nine;
                    img.transform.GetChild(11).GetComponent<TextMeshProUGUI>().text = json.myList.school[i].ten;
                    img.transform.GetChild(12).GetComponent<TextMeshProUGUI>().text = json.myList.school[i].eleven;
                    img.transform.GetChild(13).GetComponent<TextMeshProUGUI>().text = json.myList.school[i].twelve;
                    img.transform.GetChild(14).GetComponent<TextMeshProUGUI>().text = json.myList.school[i].thirteen;
                    img.transform.GetChild(15).GetComponent<TextMeshProUGUI>().text = json.myList.school[i].fourteen;
                    img.transform.GetChild(16).GetComponent<TextMeshProUGUI>().text = json.myList.school[i].fifteen;
                }
                count1.GetComponent<TextMeshProUGUI>().text = (parent.transform.childCount).ToString();
                StartCoroutine(headCount());
            }
        }
        else
        {
            this.aud.Play();
            alarm2.SetActive(true);
        }
    }
    IEnumerator headCount()
    {
        int c = 0;
        int limit = 0;
        int number = 0;

        while (true)
        {
            for (int i = 0; i < json.myList.school.Length; i++)
            {
                //tag가 i인 객체 찾기
                GameObject obj = GameObject.FindWithTag((i + 1).ToString());

                if ((obj == null) || obj.transform.GetChild(11).GetComponent<TextMeshProUGUI>().text == "FULL")
                    continue;

                if (seconds <= 10) c = Random.Range(0, 6);
                else if (seconds <= 30) c = Random.Range(3, 6);
                else c = Random.Range(5, 7);

                limit = int.Parse(obj.transform.GetChild(10).GetComponent<TextMeshProUGUI>().text);
                number = int.Parse(obj.transform.GetChild(11).GetComponent<TextMeshProUGUI>().text);

                number += c;

                if (limit < number)
                {
                    obj.transform.GetChild(11).GetComponent<TextMeshProUGUI>().text = "FULL";
                }else
                    obj.transform.GetChild(11).GetComponent<TextMeshProUGUI>().text = number.ToString();
            }


            yield return new WaitForSeconds(1.0f);
        }
    }


}

