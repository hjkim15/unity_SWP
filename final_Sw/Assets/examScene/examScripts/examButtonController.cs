using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class examButtonController : MonoBehaviour
{
    //GameObject button1;
    GameObject finder;
    //GameObject file1;
    GameObject docx;
    // Camera camera;

    GameObject[] buttons = new GameObject[6];
    GameObject[] files = new GameObject[3]; //C++ Java Python
    // bool[] noFile = new bool[3];

    // Start is called before the first frame update
    void Start()
    {
        //button1 = GameObject.Find("Button1");   
        finder = GameObject.Find("finder");
        //file1 = GameObject.Find("C++.docx");
        docx = GameObject.Find("docx");

        finder.SetActive(false);
        docx.SetActive(false);

        for (int i = 0; i < 6; i++)
        { //버튼 안보이게.
            string buttonN = "Button" + (i + 1).ToString();
            //string fileN = "file"
            buttons[i] = GameObject.Find(buttonN);
            buttons[i].SetActive(false);
        }

        files[0] = GameObject.Find("C++.docx");
        files[1] = GameObject.Find("Java.docx");
        files[2] = GameObject.Find("Python.docx");

        for (int i = 0; i < 3; i++)
        {
            files[i].SetActive(false);
        }
        // for(int i =0;i<3;i++){
        //     noFile[i] = false;
        // }
    }

    public void openFolder()
    { //folder 버튼들 누를 때
        finder.SetActive(true);
        docx.SetActive(true);
        setButton(false);
    }

    public void closeFinder()
    { //finder x 누를 때
        finder.SetActive(false);
        docx.SetActive(false);
        //files.SetActive(false);//이렇게 해도 전부 다 꺼지는지 확인해야.
        setButton(true);

        for (int i = 0; i < 3; i++)
        {
            // if(GameObject.Find(files[i].ToString())){ //파일 존재하면 끄기.
            if (files[i] != null) //오브젝트 소멸된 경우는 안함. 
                files[i].SetActive(false);
            // Debug.Log(i.ToString() + (" 파일 찾아서 껐다."));
            // }
        }
    }

    public void setButton(bool st)
    { //버튼 화면에 보이게.
        for (int i = 0; i < 6; i++)
        {
            buttons[i].SetActive(st);
        }
    }

    public void setFile(bool st)
    { //버튼 화면에 보이게.
        finder.SetActive(false);
        docx.SetActive(false);
        for (int i = 0; i < 3; i++)
        {
            if (files[i] != null)
                files[i].SetActive(st);
        }
    }

    public void openFile(int i)
    {
        //if(GameObject.Find(files[i].ToString())){
        files[i].SetActive(true);
        Debug.Log(i.ToString() + " 파일 열었다.");
        // }   
        // else{
        //     Debug.Log("파일 이미 찾음.");
        // }
    }

    public void offFolder()
    {
        if (Camera.main.transform.position.x != 60)
        {
            setButton(false);
            setFile(false);
            //closeFinder();

        }
    }

    public void pushButton()
    {
        if (Camera.main.transform.position.x != 0)
        {
            Camera.main.transform.position = new Vector3(0, 0, -10);
            gameObject.GetComponent<examTestController>().setCameraPosition(0);
            //backButton.SetActive(false);
        }
    }

    public void home()
    {
        if (PlayerPrefs.GetInt("retry") == 0)
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().saveCalDate(23);
            SceneManager.LoadScene("calendarScene");
        }
        else if (PlayerPrefs.GetInt("retry") == 1)
        {
            SceneManager.LoadScene("endScene");
        }

    }
}
