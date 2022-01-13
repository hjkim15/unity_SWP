using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MTGameDirector : MonoBehaviour
{
    public string[] game_name = new string[17];
    public string[] game_explanation = new string[17];
    GameObject question;

    int flag = 0; //처음 코멘트에서 사용
    int one = 0, two = 0, three = 0, four = 0, five = 0; //5문제 출제
    public int now = 0; //문제 번호
    public bool check = false; // 시작 안됨
    public bool check2 = false; //효과음 제어 -update()

    List<int> list = new List<int>();
    float[,] xloc = new float[5, 5];
    float[,] yloc = new float[5, 5];
    char[] extra = new char[25];

    public AudioClip next;
    AudioSource aud;

    //문제 체크
    string input = "";
    int cardcnt = 0;
    public int correct = 0; //맞은 개수
    // Start is called before the first frame update
    void Start()
    {
        this.question = GameObject.Find("explanation");
        this.game_name[0] = "바니바니";
        this.game_name[1] = "지하철";
        this.game_name[2] = "눈치";
        this.game_name[3] = "공공칠빵";
        this.game_name[4] = "훈민정음";
        this.game_name[5] = "손병호";
        this.game_name[6] = "딸기";
        this.game_name[7] = "응답하라";
        this.game_name[8] = "클레오파트라";
        this.game_name[9] = "오렌지";
        this.game_name[10] = "이어말하기";
        this.game_name[11] = "더게임오브데스";
        this.game_name[12] = "출석부";
        this.game_name[13] = "홍삼";
        this.game_name[14] = "공동묘지";
        this.game_name[15] = "만두";

        this.game_explanation[0] = "노래로 시작하며 노래가 끝나면 게임 발화자는 바니바니라 말 하며 자신의 입에 주먹을 댄 후 다시 바니바니라 말하면서 다른 사람에게 두 주먹을 가리킨다. 이 때 주먹을 받은 사람은 다시 바니바니할때 자신의 주먹을 입에 대고 다시 다른 사람에게 주먹을 가리킨다. 이 때 주먹을 받은 사람의 양 옆 사람은 바니바니 바니바니 할 동안 당근 당근을 해야하며 팔을 └ㅇ┐ ┌ㅇ┘ 이런 식으로 교차 해야 한다. 그리고 누군가 실수 할 때까지 계속 게임을 진행한다. 이 게임은 무엇일까요?";
        this.game_explanation[1] = "게임 시작시 발회자가 지하철 노선 중 하나를 정한 후 그 노선에 속한 역이름을 부른다. 그 후 일정한 방향으로 주자가 바뀌면서 그 노선에 속한 지하철역 이름을 부르되, 환승역 (서울역, 잠실역 등)일 경우엔 환승역이 속한 다른 노선으로 변경이 가능하다. 만약, 역 이름을 제한된 시간 내에 말하지 못하거나, 이미 말하였던 역을 말하거나, 다른 노선의 역을 말한 경우 ,옛날에 썼으나 지금은 쓰지 않는 역 이름을 말할 경우는 제외한다. 이 게임은 무엇일까요?";
        this.game_explanation[2] = "게임 발회자가 숫자 1을 부르면 게임참가자가 다음 숫자를 1씩 올라가면서 부르고 가장 마지막에 숫자를 부른사람이 벌칙을 당하고 게임을 종료한다. 만일, 도중에 한숫자를 두명이상이 동시에 부르는 경우 게임을 종료하고 그 숫자를 부른 사람이 벌칙을 받는다.";
        this.game_explanation[3] = "시작자가 손가락으로 자신의 앞에 007가방을 그리는 것으로 시작한다. 시작자가 공이라 말하며 한 명을 지목한다. 그 지목당한 사람 또한 공이라 말하며 다른 사람을 지목한다. 이번에 지목당한 사람은 칠이라 말하며 다른 사람을 지목하고, 이어서 지목 당한 사람은 빵이라 말하며 다른 사람을 지목한다. 이번에 지목 당한 사람의 양옆 두 명이 으악이라 외치며 손을 잽싸게 들어야 한다. 이 때, 다른 사람들은 가만히 있어야 한다. 이 게임은 무엇일까요?";
        this.game_explanation[4] = "술래가 두 글자 초성을 부르면 나머지 사람들이 해당 되는 초성의 단어를 빠르게 먼저 외쳐주면서 술래와 하이파이브를 하는 게임은 무엇일까요?";
        this.game_explanation[5] = "다섯 손가락을 펴고 한명씩 돌아가면서 단체 질문을 합니다. 그 질문에 해당이 되면 한 손가락씩 접어서 다섯 손가락이 다 접히면 지게 되는 게임은 무엇일까요?";
        this.game_explanation[6] = "아이엠그라운드 동작에 맞추어 딸기 1- 딸기8까지 차례대로 한 후 거꾸로 딸기8 이후에는 딸기 7, 딸기 6으로 줄어드는 게임은 무엇일까요?";
        this.game_explanation[7] = "지인에게 핸드폰 카톡 및 문자등을 보낸 후 가장 답이 늦게 오는 사람이 걸리는 게임은 무엇일까요?";
        this.game_explanation[8] = "안녕 OOOOOO 세상에서 제일가는 포테토칩 이라고 부르면서 한 사람씩 음을 높여가는 게임은 무엇일까요?";
        this.game_explanation[9] = "손으로 둥글게 오렌지를 만들면서 오렌지~를 4번 반복한 후 마지막에 오라고 외치며 상대방에게 전달합니다. 이걸 받은 상대방은 전 사람이 만든 모양보다 크게 하고 소리도 크게 외쳐아하는 이 게임은 무엇일까요?";
        this.game_explanation[10] = "문장이 끝나면 2,3글자 정도 정해놓고 3박자로 이어나갑니다. 예를 들어 질문자가 스타라고 외치면 이어 받은 사람은 벅스,필드 등 이어서 말해야 합니다. 이 게임은 무엇일까요?";
        this.game_explanation[11] = "술래가 신난다, 재미난다, 더 게임 오브데스라고 외치면 모든 사람이 손가락으로 아무나 지목한다. 지목이 끝난 후 술래는 숫자를 말한 후 자신부터 지목 순서대로 손끝을 따라 숫자를 세고 마지막 숫자가 불린 사람이 지는 게임이다. 이것은 무엇일까요?";
        this.game_explanation[12] = "출석부, 출석부라는 구호에 맞추어 팔을 허리에 붙혔다 뗐다를 반복한다. 이 리듬에 맞추다가 술래는 이름을 부르며 누군가를 지목하면서 지목한 사람 외의 다른 사람의 이름을 외쳐야합니다. 이때 이름이 호명된 사람이 네를 외친 후 다시 술래가 된다. 이 게임은 무엇일까요?";
        this.game_explanation[13] = "아싸 홍삼 지금부터 시작 아싸 너너하면서 술래가 두 사람을 지목하면 각 두명이 또 다른 두명을 지명한다. 이 때 한명이 두명으로부터 지명을 받으면 지는 게임이다. 이 게임은 무엇인가요?";
        this.game_explanation[14] = "아싸 OOOO에 올라갔더니 시체가 벌떡을 5번하고 아~쇼킹을 점점 크게 하는 게임이다. 이것은 무엇인가요?";
        this.game_explanation[15] = "손바닥을 위로 한 상태에서 손가락을 오므려 만두 모양을 합니다. 만두 만두 만두만두\"를 위치고 5의 배수로 숫자를 말하되 최대 숫자는 자리에 있는 사람수의 5배까지 가능합니다. 이 게임은 무엇일까요?";

        this.aud = GetComponent<AudioSource>();

        for (int i = 0; i < 25; i++) list.Add(i);

        for (int i = 0; i < 5; i++)
        {
            xloc[i, 0] = -7.7f;
            xloc[i, 1] = -6.37f;
            xloc[i, 2] = -5.08f;
            xloc[i, 3] = -3.7f;
            xloc[i, 4] = -2.5f;
        }

        for (int i = 0; i < 5; i++)
        {
            yloc[0, i] = 3.87f;
            yloc[1, i] = 2.85f;
            yloc[2, i] = 1.54f;
            yloc[3, i] = 0.39f;
            yloc[4, i] = -0.69f;
        }

        this.extra[0] = '가';
        this.extra[1] = '나';
        this.extra[2] = '다';
        this.extra[3] = '라';
        this.extra[4] = '마';
        this.extra[5] = '바';
        this.extra[6] = '사';
        this.extra[7] = '아';
        this.extra[8] = '자';
        this.extra[9] = '차';
        this.extra[10] = '카';
        this.extra[11] = '타';
        this.extra[12] = '파';
        this.extra[13] = '하';
        this.extra[14] = '김';
        this.extra[15] = '병';
        this.extra[16] = '복';
        this.extra[17] = '수';
        this.extra[18] = '우';
        this.extra[19] = '미';
        this.extra[20] = '양';
        this.extra[21] = '피';
        this.extra[22] = '노';
        this.extra[23] = '방';
        this.extra[24] = '게';

        Invoke("comment", 5);

        make_random();
        make_puzzle();
    }

    // Update is called once per frame
    void Update()
    {
        if (correct < 0) correct = 0;
    }

    //문제 출제
    public void makequestion()
    {

        if (now == 0)
        {
            this.aud.PlayOneShot(this.next);
            this.question.GetComponent<Text>().text = game_explanation[one];

        }
        else if (now == 1)
        {
            this.aud.PlayOneShot(this.next);
            this.question.GetComponent<Text>().text = game_explanation[two];
        }
        else if (now == 2)
        {
            this.aud.PlayOneShot(this.next);
            this.question.GetComponent<Text>().text = game_explanation[three];

        }
        else if (now == 3)
        {
            this.aud.PlayOneShot(this.next);
            this.question.GetComponent<Text>().text = game_explanation[four];

        }
        else if (now == 4)
        {
            this.aud.PlayOneShot(this.next);
            this.question.GetComponent<Text>().text = game_explanation[five];

        }
        else
        {
            this.question.GetComponent<Text>().text = "게임 종료";
            Debug.Log("종료");
            Invoke("result", 3);
        }

    }

    //게임 종료시 씬 전환
    public void gameOver()
    {
        PlayerPrefs.SetInt("MTR", this.correct);


        if (PlayerPrefs.GetInt("retry") == 0)
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().saveCalDate(7);
            SceneManager.LoadScene("calendarScene");
        }
        else if (PlayerPrefs.GetInt("retry") == 1)
        {
            SceneManager.LoadScene("endScene");
        }
    }


    //게임 결과, 맞은 개수 출력
    public void result()
    {
        GameObject.Find("Canvas").SetActive(false);
        float xresult = correct * 20 + 20;
        GameObject.Find("Main Camera").transform.position = new Vector3(xresult, 0, -10);
        Invoke("gameOver", 5.0f);
    }

    //카드 투명도 조절
    public void game(string s)
    {
        if (cardcnt > 6) return;
        GameObject button = GameObject.Find("card" + cardcnt); // 방금 클릭한 게임 오브젝트의 이름과 버튼 속 문자 출력

        button.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        button.GetComponentInChildren<TextMeshProUGUI>().text = s;
        button.GetComponentInChildren<TextMeshProUGUI>().fontSize = 80;
        input += s;
        cardcnt++;

    }
    //retry 버튼 눌려서 카드 초기화
    public void regame()
    {
        input = "";
        for (int i = 0; i < cardcnt; i++)
        {
            GameObject button = GameObject.Find("card" + i); // 방금 클릭한 게임 오브젝트의 이름과 버튼 속 문자 출력

            button.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
            button.GetComponentInChildren<TextMeshProUGUI>().text = "";
        }
        cardcnt = 0;
    }
    //정답 맞는지 확인
    public bool checkgame()
    {
        if (now == 0)
        {
            if (input == game_name[one])
            {
                return true;
            }
            else return false;
        }
        else if (now == 1)
        {
            if (input == game_name[two])
            {

                return true;
            }
            else return false;
        }
        else if (now == 2)
        {
            if (input == game_name[three])
            {
                return true;
            }
            else return false;
        }
        else if (now == 3)
        {
            if (input == game_name[four])
            {
                return true;
            }
            else return false;
        }
        else if (now == 4)
        {
            if (input == game_name[five])
            {
                return true;
            }
            else return false;
        }

        return false;
    }

    //게임 랜덤으로 섞기
    public void shuffles()
    {
        for (int i = 1; i < 26; i++)
        {
            int rand1 = Random.Range(0, 25);
            int rand2 = Random.Range(0, 25);

            int tmp = list[rand1];
            list[rand1] = list[rand2];
            list[rand2] = tmp;
        }
    }
    //출제할 게임 랜덤으로 정하기
    void make_random()
    {
        one = Random.Range(0, 3);
        two = Random.Range(3, 6);
        three = Random.Range(6, 9);
        four = Random.Range(9, 12);
        five = Random.Range(12, 16);
    }
    //각 글자를 25칸에 출력
    void make_puzzle()
    {
        int sum = game_name[one].Length + game_name[two].Length + game_name[three].Length + game_name[four].Length + game_name[five].Length;
        while (sum > 25) make_random();

        shuffles();

        int cnt = 0;
        for (int i = 0; i < game_name[one].Length; i++)
        {
            char c = game_name[one][i];
            if (cnt >= 25) break;
            GameObject button = GameObject.Find("Button" + list[cnt].ToString()); // 방금 클릭한 게임 오브젝트의 이름과 버튼 속 문자 출력
            button.GetComponentInChildren<TextMeshProUGUI>().text = "" + c;
            button.GetComponentInChildren<TextMeshProUGUI>().fontSize = 50;
            cnt++;

        }
        for (int i = 0; i < game_name[two].Length; i++)
        {
            char c = game_name[two][i];
            if (cnt >= 25) break;
            GameObject button = GameObject.Find("Button" + list[cnt].ToString()); // 방금 클릭한 게임 오브젝트의 이름과 버튼 속 문자 출력
            button.GetComponentInChildren<TextMeshProUGUI>().text = "" + c;
            button.GetComponentInChildren<TextMeshProUGUI>().fontSize = 50;
            cnt++;

        }
        for (int i = 0; i < game_name[three].Length; i++)
        {
            char c = game_name[three][i];
            if (cnt >= 25) break;
            GameObject button = GameObject.Find("Button" + list[cnt].ToString()); // 방금 클릭한 게임 오브젝트의 이름과 버튼 속 문자 출력
            button.GetComponentInChildren<TextMeshProUGUI>().text = "" + c;
            button.GetComponentInChildren<TextMeshProUGUI>().fontSize = 50;
            cnt++;
        }
        for (int i = 0; i < game_name[four].Length; i++)
        {
            char c = game_name[four][i];
            if (cnt >= 25) break;
            GameObject button = GameObject.Find("Button" + list[cnt].ToString()); // 방금 클릭한 게임 오브젝트의 이름과 버튼 속 문자 출력
            button.GetComponentInChildren<TextMeshProUGUI>().text = "" + c;
            button.GetComponentInChildren<TextMeshProUGUI>().fontSize = 50;
            cnt++;

        }
        for (int i = 0; i < game_name[five].Length; i++)
        {
            char c = game_name[five][i];
            if (cnt >= 25) break;
            GameObject button = GameObject.Find("Button" + list[cnt].ToString()); // 방금 클릭한 게임 오브젝트의 이름과 버튼 속 문자 출력
            button.GetComponentInChildren<TextMeshProUGUI>().text = "" + c;
            button.GetComponentInChildren<TextMeshProUGUI>().fontSize = 50;
            cnt++;

        }

        int cnt2 = 0;
        for (; cnt < 25; cnt++)
        {
            GameObject button = GameObject.Find("Button" + list[cnt].ToString()); // 방금 클릭한 게임 오브젝트의 이름과 버튼 속 문자 출력
            button.GetComponentInChildren<TextMeshProUGUI>().text = "" + this.extra[cnt2];
            button.GetComponentInChildren<TextMeshProUGUI>().fontSize = 50;
            cnt2++;
        }

    }
    //처음 시작할 때 게임 소개
    void comment()
    {

        if (flag == 0)
        {
            this.aud.PlayOneShot(this.next);
            this.question.GetComponent<Text>().text = "안녕하세요 수정님. 저는 성신여자 대학교를 다니는 N년차 재학생 성수룡입니다. MT에서 배울 게임들에 대해 퀴즈를 조금 내보려해요. ";
            flag = 1;
            Invoke("comment", 5);
        }
        else if (flag == 1)
        {
            this.aud.PlayOneShot(this.next);
            this.question.GetComponent<Text>().text = "랜덤으로 배치된 25개의 글자 중 설명에 해당되는 게임이름에 맞추어 선택해주시면 됩니다. 2번 눌러야 선택이 되며 초기화를 원하시면 retry를 누르고 정답이 맞는지 확인하고 싶으시면 check 버튼을 눌러주세요!";
            flag = 2;
            Invoke("comment", 10);
        }
        else if (flag == 2)
        {
            this.aud.PlayOneShot(this.next);
            this.question.GetComponent<Text>().text = "그럼 시작해볼까요?";
            flag = 3;
            Invoke("comment", 5);

        }
        else
        {
            Invoke("makequestion", 5);
        }
    }

}

