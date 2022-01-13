using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class endSceneUIController : MonoBehaviour
{
    endSceneDirector Director;

    // Start is called before the first frame update
    void Start()
    {
        getDetails();
        this.Director = gameObject.GetComponent<endSceneDirector>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void getDetails()
    {
        GameObject.Find("name_info").GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetString("Name");
        GameObject.Find("ID_info").GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetString("ID");


    }

    public void showScores()
    {
        GameObject.Find("registerS").GetComponent<TextMeshProUGUI>().text = Director.showScore(1);
        GameObject.Find("quizS").GetComponent<TextMeshProUGUI>().text = Director.showScore(2);
        GameObject.Find("commuteS").GetComponent<TextMeshProUGUI>().text = Director.showScore(3);
        GameObject.Find("mtS").GetComponent<TextMeshProUGUI>().text = Director.showScore(4);
        GameObject.Find("albeitS").GetComponent<TextMeshProUGUI>().text = Director.showScore(5);
        GameObject.Find("hwS").GetComponent<TextMeshProUGUI>().text = Director.showScore(6);
        GameObject.Find("examS").GetComponent<TextMeshProUGUI>().text = Director.showScore(7);
    }

 
}
