using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizJson : MonoBehaviour
{
    public TextAsset quiztext;

    [System.Serializable]
    public class Quiz
    {
        public string question;
        public string answer;
        public string[] option;
        public string explain;
    }

    [System.Serializable]
    public class QuizList
    {
        public Quiz[] quiz;

    }
    public QuizList myList = new QuizList();


    void Start()
    {
        myList = JsonUtility.FromJson<QuizList>(quiztext.text);

        int random1, random2;
        Quiz temp;

        for (int i = 0; i < myList.quiz.Length; ++i)
        {
            random1 = Random.Range(0, myList.quiz.Length);
            random2 = Random.Range(0, myList.quiz.Length);

            temp = myList.quiz[random1];
            myList.quiz[random1] = myList.quiz[random2];
            myList.quiz[random2] = temp;
        }

        int random3, random4;
        string temp1;

        for (int i = 0; i < myList.quiz.Length; i++) {
            for (int j = 0; j < myList.quiz[i].option.Length; ++j)
            {
                random3 = Random.Range(0, myList.quiz[i].option.Length);
                random4 = Random.Range(0, myList.quiz[i].option.Length);

                temp1 = myList.quiz[i].option[random3];
                myList.quiz[i].option[random3] = myList.quiz[i].option[random4];
                myList.quiz[i].option[random4] = temp1;
            } 
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
