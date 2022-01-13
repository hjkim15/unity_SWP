using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_InputField inputName;
    public TMP_InputField inputID;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void saveCalDate(int d) //날짜 설정. 
    {
        PlayerPrefs.SetInt("CalDate", d);
    }

    public int loadCalDate() //날짜 설정 리턴.
    {
        if (PlayerPrefs.HasKey("CalDate"))
        {
            return PlayerPrefs.GetInt("CalDate");
        }
        else
        {
            saveCalDate(16);
            return 16;
        }
    }

    public void startGame() {
        PlayerPrefs.DeleteAll();

        PlayerPrefs.SetString("Name", inputName.text);
        PlayerPrefs.SetString("ID", inputID.text);
        PlayerPrefs.SetInt("retry", 0);


        //PlayerPrefs.DeleteKey("CalDate");
        ////여기에 초기화 시켜야 하는 결과값들 DeleteKey()로 해주기.
        //PlayerPrefs.DeleteKey("AlbeitR");
    }

    //public void enterName()

    
}
