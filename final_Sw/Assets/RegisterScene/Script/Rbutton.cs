using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class Rbutton : MonoBehaviour
{
    public GameObject result;
    public TMP_Text writeT;
    public TMP_Text writeL;
    public TMP_Text writeL2;
    GameObject count;
    GameObject count1;
    GameObject count2;

    GameDirector gD;
    GameObject Parent;
    GameObject parent1;
    GameObject parent2;

    int n = 0;
    int n1 = 0;
    int n2 = 0;
    float t = 0;
    bool p1, check = false;
    List<string> list = new List<string>(); //전공
    List<string> list2 = new List<string>(); //교양
    int listC;
    int list2C;


    void Start()
    {
        this.count = GameObject.Find("count");
        this.count1 = GameObject.Find("count1");
        this.count2 = GameObject.Find("count2");
        this.parent1 = GameObject.Find("Parent");
        this.parent2 = GameObject.Find("Parent2");
        gD = GameObject.Find("director").GetComponent<GameDirector>();
        this.listC = 0;
        this.list2C = 0;
    }

    void Update()
    {
        n1 = parent1.transform.childCount;
        n2 = parent2.transform.childCount;

        count.GetComponent<TextMeshProUGUI>().text = (3 * parent2.transform.childCount).ToString();
        count1.GetComponent<TextMeshProUGUI>().text = "[" + (parent1.transform.childCount).ToString() + "]";
        count2.GetComponent<TextMeshProUGUI>().text = "[" + (parent2.transform.childCount).ToString() + "]";

        parent2.transform.GetChild(0).GetChild(1).gameObject.SetActive(false);

        if (gD.hour == 10)
        {
            if (this.check == false)
            {
                t += Time.deltaTime;
            }
        }
    }

    public void SceneChange()
    {
        //학점 저장한 변수를 playerPref로 저장.

        PlayerPrefs.SetInt("RegisterR", int.Parse(count.GetComponent<TextMeshProUGUI>().text));
        PlayerPrefs.SetInt("RegisterRM", this.listC);
        PlayerPrefs.SetInt("RegisterRNM", this.list2C);

        if (PlayerPrefs.GetInt("retry") == 0)
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().saveCalDate(18);
            SceneManager.LoadScene("calendarScene");
        }
        else if (PlayerPrefs.GetInt("retry") == 1)
        {
            SceneManager.LoadScene("endScene");
        }
    }

    public void show()
    {
        result.SetActive(true);
        check = true;
        Time.timeScale = 0f;
    }
    public void close2()
    {
        gD.alarm4.SetActive(false);
    }
    public void close3()
    {
        gD.alarm3.SetActive(false);
    }

    public void close4()
    {
        result.SetActive(false);
        check = false;
        Time.timeScale = 1.0f;
    }
    public void registerClick()
    {
        gD.select();
        //클릭한 버튼이 신청
        if (this.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "신청")
        {
            p1 = true;
            if (this.transform.parent.GetChild(11).GetComponent<TextMeshProUGUI>().text == "FULL")
            {
                gD.aud.Play();
                Parent = parent1;
                n = n1;

                gD.alarm3.SetActive(true);

            }
            else if (int.Parse(count.GetComponent<TextMeshProUGUI>().text) > 15)
            {
                gD.aud.Play();
                Parent = parent1;
                n = n1;
                gD.alarm4.SetActive(true);

            }
            else
            {
                Parent = parent2;
                n = n2;
                this.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "취소";
            }


        }
        else
        {//클릭한 버튼이 취소
            p1 = false;
            Parent = parent1;
            n = n1;

            if (this.transform.parent.GetChild(11).GetComponent<TextMeshProUGUI>().text == "FULL")
            {
                int a = int.Parse((this.transform.parent.GetChild(10).GetComponent<TextMeshProUGUI>().text));
                this.transform.parent.GetChild(11).GetComponent<TextMeshProUGUI>().text = (a - 1).ToString();
            }
            else
            {
                int a = int.Parse((this.transform.parent.GetChild(11).GetComponent<TextMeshProUGUI>().text));
                this.transform.parent.GetChild(11).GetComponent<TextMeshProUGUI>().text = (a - 1).ToString();
            }

            this.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "신청";

        }

        this.transform.parent.SetParent(Parent.transform);


        int c;
        if (p1) c = 1;
        else c = 0;
        //No 숫자 설정
        for (int i = c; i < Parent.transform.childCount; i++)
        {
            Parent.transform.GetChild(i).GetChild(0).GetComponent<TextMeshProUGUI>().text = (i + 1).ToString();
        }


    }

    public void writeTime()
    {
        float minute = 0;
        float second = 0;

        minute = t / 60;
        second = t % 60;

        writeT.text = (int)minute + "분 " + (int)second + "초";
    }

    public void writeList()
    {
        writeL.text = "";
        writeL2.text = "";

        for (int i = 0; i < parent2.transform.childCount; i++)
        {
            if (parent2.transform.GetChild(i).GetChild(2).GetComponent<TextMeshProUGUI>().text == "교양학부")
                this.list2.Add(parent2.transform.GetChild(i).GetChild(4).GetComponent<TextMeshProUGUI>().text);
            else
                this.list.Add(parent2.transform.GetChild(i).GetChild(4).GetComponent<TextMeshProUGUI>().text);

        }

        for (int i = 0; i < list.Count; i++)
        {
            writeL.text += list[i].ToString() + "\n";
        }

        for (int i = 0; i < list2.Count; i++)
        {
            writeL2.text += list2[i].ToString() + "\n";
        }

        this.listC = list.Count;
        this.list2C = list2.Count;

        list.Clear();
        list2.Clear();

    }

}

