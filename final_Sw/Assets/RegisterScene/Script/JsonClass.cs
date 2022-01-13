using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class JsonClass : MonoBehaviour
{
    public TextAsset textJ;

    [System.Serializable]
    public class School
    {
        public string one;
        public string two;
        public string three;
        public string four;
        public string five;
        public string six;
        public string seven;
        public string eight;
        public string nine;
        public string ten;
        public string eleven;
        public string twelve;
        public string thirteen;
        public string fourteen;
        public string fifteen;

    }

    [System.Serializable]
    public class classList
    {
        public School[] school;

    }

    public classList myList = new classList();

    // Start is called before the first frame update
    void Start()
    {
       // string str = File.ReadAllText(Application.dataPath + "/infromation.json");
        myList = JsonUtility.FromJson<classList>(textJ.text);

            int random1, random2;
            School temp;

            for (int i = 0; i < myList.school.Length; ++i)
            {
                random1 = Random.Range(0, myList.school.Length);
                random2 = Random.Range(0, myList.school.Length);

                temp = myList.school[random1];
            myList.school[random1] = myList.school[random2];
            myList.school[random2] = temp;
            }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
