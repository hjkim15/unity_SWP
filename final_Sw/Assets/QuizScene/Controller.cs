using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class Controller : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;

    public GameObject question1;
    public GameObject question2;

    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;

    public GameObject result1;
    public GameObject result2;
    public GameObject img1;
    public GameObject img2;
    public GameObject explainPannel;
    public TMP_Text ep;

    public Image slide;

    GameObject clickObject;
    GameObject Qcount;
    GameObject point;
    GameObject show;
    GameObject rightButton;
    GameObject wrongButton;
    QuizJson qJson;
    Button answer;

    AudioSource aud;
    AudioSource aud2;
    public AudioClip rightSound;
    public AudioClip wrongSound;

    public bool next = false;
    bool case1, case2, case3, case4 = false;
    bool aCheck, slideStop = false;
    string ans, ep1;
    int i = 0;
    int count = 0;
    int Point;
    float timeLeft2;
    void Start()
    {
        qJson = GameObject.Find("director").GetComponent<QuizJson>();
        point = GameObject.Find("point");
        Qcount = GameObject.Find("Qcount");
        rightButton = GameObject.Find("rightButton");
        wrongButton = GameObject.Find("wrongButton");

        this.aud = GetComponent<AudioSource>();
        this.aud2 = GameObject.Find("Canvas").GetComponent<AudioSource>();
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);

        load();
    }
    void Update()
    {

    }
    public void oxButton()
    {
        clickObject = EventSystem.current.currentSelectedGameObject;

        if (clickObject.tag == ans)
        {
            Point += 10;
            count++;
            point.GetComponent<TextMeshProUGUI>().text = Point.ToString();
            case1 = true;
            aCheck = true;
        }
        else
        {
            Point -= 10;
            if (Point <= 0) Point = 0;
            point.GetComponent<TextMeshProUGUI>().text = Point.ToString();
            case2 = true;
        }
        StartCoroutine(showAnswer());
        StartCoroutine(checkAnswer());
    }

    public void select()
    {
        clickObject = EventSystem.current.currentSelectedGameObject;

        if (clickObject.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == ans)
        {
            Point += 10;
            count++;
            point.GetComponent<TextMeshProUGUI>().text = Point.ToString();
            case3 = true;
            aCheck = true;
        }
        else
        {
            Point -= 10;
            if (Point <= 0) Point = 0;
            point.GetComponent<TextMeshProUGUI>().text = Point.ToString();
            case4 = true;
        }
        StartCoroutine(showAnswer());
        StartCoroutine(checkAnswer());
    }

    void clearButton()
    {
        clickObject.GetComponent<Button>().image.color = new Color32(255, 255, 255, 255);
        for (int i = 1; i < 5; i++)
        {
            GameObject obj = panel1.transform.GetChild(0).GetChild(i).gameObject;
            panel1.transform.GetChild(0).GetChild(i).GetComponent<Button>().image.color = new Color32(255, 255, 255, 255);
        }
    }
    void load()
    {
        this.aud2.volume = 1;
        panel4.SetActive(false);
        slideStop = false;
        StartCoroutine(timeSlide());
        StartCoroutine(nextWait2());
        Qcount.GetComponent<TextMeshProUGUI>().text = (i + 1).ToString();

        if (i < qJson.myList.quiz.Length)
        {
            //ox퀴즈
            if (qJson.myList.quiz[i].option.Length == 0)
            {
                panel2.SetActive(true);
                panel1.SetActive(false);

                if (qJson.myList.quiz[i].question.Length > 20)
                    question2.GetComponent<TextMeshProUGUI>().fontSize = 50;
                question2.GetComponent<TextMeshProUGUI>().text = qJson.myList.quiz[i].question;
            }
            else
            {//4지선다형
                panel1.SetActive(true);
                panel2.SetActive(false);

                if (qJson.myList.quiz[i].question.Length > 20)
                    question1.GetComponent<TextMeshProUGUI>().fontSize = 50;

                question1.GetComponent<TextMeshProUGUI>().text = qJson.myList.quiz[i].question;
                button1.GetComponent<TextMeshProUGUI>().text = qJson.myList.quiz[i].option[0];
                button2.GetComponent<TextMeshProUGUI>().text = qJson.myList.quiz[i].option[1];
                button3.GetComponent<TextMeshProUGUI>().text = qJson.myList.quiz[i].option[2];
                button4.GetComponent<TextMeshProUGUI>().text = qJson.myList.quiz[i].option[3];

            }
            this.ans = qJson.myList.quiz[i].answer;
            this.ep1 = qJson.myList.quiz[i].explain;

            StartCoroutine(nextWait());
        }
        else
        {
            panel3.SetActive(true);
            result1.GetComponent<TextMeshProUGUI>().text = "맞은 문제 수 : " + count;
            result2.GetComponent<TextMeshProUGUI>().text = "S마일리지 점수 : " + Point;
            PlayerPrefs.SetInt("QuizR", Point);
        }


    }

    IEnumerator timeSlide()
    {
        float timeLeft = 10.0f;
        while (true)
        {
            if (slideStop == false)
            {
                if (timeLeft >= 0)
                {
                    timeLeft -= Time.deltaTime;
                    slide.fillAmount = timeLeft / 10;
                    getTime(timeLeft);
                    Debug.Log(timeLeft);
                }

            }
            else
            {
                yield break;
            }
            yield return null;

        }

    }

    void getTime(float timeLeft)
    {
        timeLeft2 = timeLeft;
    }

    IEnumerator showAnswer()
    {
        this.aud2.volume = 0.2f;
        panel4.SetActive(true);
        slideStop = true;
        if (aCheck)//정답이라면
        { show = img1; aCheck = false; this.aud.PlayOneShot(this.rightSound); }
        else
        { show = img2; this.aud.PlayOneShot(this.wrongSound); }

        show.SetActive(true);
        while (true)
        {
            if (show.GetComponent<Image>().fillAmount >= 1)
            {
                show.GetComponent<Image>().fillAmount = 1; break;
            }
            show.GetComponent<Image>().fillAmount += 0.01f;
            yield return null;
        }


    }

    IEnumerator nextWait()
    {
        next = false;
        yield return new WaitUntil(() => next == true);
        i++;
        load();

    }
    IEnumerator nextWait2()
    {

        yield return new WaitUntil(() => timeLeft2 < 0);
        if (i == 10)
        {
            ;
        }
        else
        {
            aCheck = false;
            StartCoroutine(showAnswer());
            StartCoroutine(checkAnswer2());
        }
    }

    IEnumerator checkAnswer()
    {
        if (case1)
        {
            case1 = false;
            clickObject.GetComponent<Button>().image.color = new Color32(120, 236, 131, 255);
            yield return new WaitForSeconds(2.5f);
            clickObject.GetComponent<Button>().image.color = new Color32(255, 255, 255, 255);
        }
        else if (case2)
        {
            case2 = false;
            clickObject.GetComponent<Button>().image.color = new Color32(203, 82, 82, 255);
            yield return new WaitForSeconds(2.5f);
            clickObject.GetComponent<Button>().image.color = new Color32(255, 255, 255, 255);
        }
        else if (case3)
        {
            case3 = false;
            clickObject.GetComponent<Button>().image.color = new Color32(120, 236, 131, 255);
            yield return new WaitForSeconds(2.5f);
            clearButton();
        }
        else if (case4)
        {
            case4 = false;

            clickObject.GetComponent<Button>().image.color = new Color32(203, 82, 82, 255);
            for (int i = 1; i < 5; i++)
            {
                GameObject obj = panel1.transform.GetChild(0).GetChild(i).gameObject;

                if (obj.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == ans)
                    panel1.transform.GetChild(0).GetChild(i).GetComponent<Button>().image.color = new Color32(120, 236, 131, 255);
            }

            yield return new WaitForSeconds(2.5f);

            clearButton();
        }
        show.GetComponent<Image>().fillAmount = 0;
        StartCoroutine(showExplain());
    }

    IEnumerator checkAnswer2()
    {
        bool change = false;
        if (ans == "true") rightButton.GetComponent<Button>().image.color = new Color32(120, 236, 131, 255);
        else if (ans == "false") wrongButton.GetComponent<Button>().image.color = new Color32(120, 236, 131, 255);
        else
        {
            for (int i = 1; i < 5; i++)
            {
                GameObject obj = panel1.transform.GetChild(0).GetChild(i).gameObject;

                if (obj.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == ans)
                {
                    answer = obj.GetComponent<Button>();
                    panel1.transform.GetChild(0).GetChild(i).GetComponent<Button>().image.color = new Color32(120, 236, 131, 255);
                    change = true;
                }
            }
        }
        yield return new WaitForSeconds(2.5f);

        rightButton.GetComponent<Button>().image.color = new Color32(255, 255, 255, 255);
        wrongButton.GetComponent<Button>().image.color = new Color32(255, 255, 255, 255);
        if (change) answer.image.color = new Color32(255, 255, 255, 255);

        show.GetComponent<Image>().fillAmount = 0;
        StartCoroutine(showExplain());
    }

    IEnumerator showExplain()
    {
        explainPannel.SetActive(true);
        ep.text = ep1;
        yield return new WaitForSeconds(4.0f);
        explainPannel.SetActive(false);
        next = true;
    }
}
