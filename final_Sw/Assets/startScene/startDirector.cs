using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class startDirector : MonoBehaviour
{
    GameObject click;
    bool clickD = true;

    //GameObject name;
    //GameObject ID;
    //GameObject nameT;
    //GameObject IDT;
    //GameObject StartButton;
    GameObject inputSet;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.DeleteKey("Name");
        //PlayerPrefs.DeleteKey("ID");

        PlayerPrefs.DeleteAll();

        this.click = GameObject.Find("click");
        this.inputSet = GameObject.Find("inputSet");
        this.inputSet.SetActive(false);
        StartCoroutine(blickText());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.clickD = false;
            this.inputSet.SetActive(true);
        }
    }

    IEnumerator blickText()
    {
        while (true)
        { //https://sosohanbox.tistory.com/159

            this.click.GetComponent<TextMeshProUGUI>().text = " ";
            yield return new WaitForSeconds(0.7f);
            if (this.clickD == true)
            {
                this.click.GetComponent<TextMeshProUGUI>().text = "CLICK!";
            }
            yield return new WaitForSeconds(0.7f);

        }

    }

    public void startButton()
    {
        startAudioManager.instance.AudioDestroy();
        SceneManager.LoadScene("calendarScene");
    }
}
