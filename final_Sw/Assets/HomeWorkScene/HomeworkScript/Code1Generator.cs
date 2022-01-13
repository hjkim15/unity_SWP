using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Code1Generator : MonoBehaviour
{
    public static Code1Generator instance = null;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            if (instance != this)
                Destroy(this.gameObject);
        }
    }

    public GameObject code1_0;
    public GameObject code1_1;
    public GameObject code1_2;
    public GameObject code1_3;
    public GameObject code1_4;
    public GameObject code1_5;

    int count;
    int code1Count;

    public int[] array1 = new int[6];

    void Start()
    {
        this.code1_0 = GameObject.Find("code1_0");
        this.code1_1 = GameObject.Find("code1_1");
        this.code1_2 = GameObject.Find("code1_2");
        this.code1_3 = GameObject.Find("code1_3");
        this.code1_4 = GameObject.Find("code1_4");
        this.code1_5 = GameObject.Find("code1_5");

        int rand1 = Random.Range(0, 6);
        this.code1Count = 0;

        array1[0] = rand1;
        array1[1] = (rand1 + 2) % 6;
        array1[2] = (rand1 + 4) % 6;
        array1[3] = (rand1 + 3) % 6;
        array1[4] = (rand1 + 1) % 6;
        array1[5] = (rand1 + 5) % 6;

        Debug.Log(array1[0]);
        Debug.Log(array1[1]);
        Debug.Log(array1[2]);
        Debug.Log(array1[3]);
        Debug.Log(array1[4]);
        Debug.Log(array1[5]);
    }


    void Update()
    {
        if (SupermanController.instance.code1Count == 1 && this.code1Count == 0)
        {
            if (array1[0] == 0)
                this.code1_0.GetComponent<Text>().text = "#include <iostream>";
            else if (array1[0] == 1)
                this.code1_1.GetComponent<Text>().text = "#include <iostream>";
            else if (array1[0] == 2)
                this.code1_2.GetComponent<Text>().text = "#include <iostream>";
            else if (array1[0] == 3)
                this.code1_3.GetComponent<Text>().text = "#include <iostream>";
            else if (array1[0] == 4)
                this.code1_4.GetComponent<Text>().text = "#include <iostream>";
            else if (array1[0] == 5)
                this.code1_5.GetComponent<Text>().text = "#include <iostream>";

            if (array1[1] == 0)
                this.code1_0.GetComponent<Text>().text = "using namespace std;";
            else if (array1[1] == 1)
                this.code1_1.GetComponent<Text>().text = "using namespace std;";
            else if (array1[1] == 2)
                this.code1_2.GetComponent<Text>().text = "using namespace std;";
            else if (array1[1] == 3)
                this.code1_3.GetComponent<Text>().text = "using namespace std;";
            else if (array1[1] == 4)
                this.code1_4.GetComponent<Text>().text = "using namespace std;";
            else if (array1[1] == 5)
                this.code1_5.GetComponent<Text>().text = "using namespace std;";

            if (array1[2] == 0)
                this.code1_0.GetComponent<Text>().text = "main function";
            else if (array1[2] == 1)
                this.code1_1.GetComponent<Text>().text = "main function";
            else if (array1[2] == 2)
                this.code1_2.GetComponent<Text>().text = "main function";
            else if (array1[2] == 3)
                this.code1_3.GetComponent<Text>().text = "main function";
            else if (array1[2] == 4)
                this.code1_4.GetComponent<Text>().text = "main function";
            else if (array1[2] == 5)
                this.code1_5.GetComponent<Text>().text = "main function";

            if (array1[3] == 0)
                this.code1_0.GetComponent<Text>().text = "cout << \"(10.5 + 2 * 3) / (45 - 3.5) = \";";
            else if (array1[3] == 1)
                this.code1_1.GetComponent<Text>().text = "cout << \"(10.5 + 2 * 3) / (45 - 3.5) = \";";
            else if (array1[3] == 2)
                this.code1_2.GetComponent<Text>().text = "cout << \"(10.5 + 2 * 3) / (45 - 3.5) = \";";
            else if (array1[3] == 3)
                this.code1_3.GetComponent<Text>().text = "cout << \"(10.5 + 2 * 3) / (45 - 3.5) = \";";
            else if (array1[3] == 4)
                this.code1_4.GetComponent<Text>().text = "cout << \"(10.5 + 2 * 3) / (45 - 3.5) = \";";
            else if (array1[3] == 5)
                this.code1_5.GetComponent<Text>().text = "cout << \"(10.5 + 2 * 3) / (45 - 3.5) = \";";

            if (array1[4] == 0)
                this.code1_0.GetComponent<Text>().text = "cout << (10.5 + 2 * 3) / (45 - 3.5) << endl;";
            else if (array1[4] == 1)
                this.code1_1.GetComponent<Text>().text = "cout << (10.5 + 2 * 3) / (45 - 3.5) << endl;";
            else if (array1[4] == 2)
                this.code1_2.GetComponent<Text>().text = "cout << (10.5 + 2 * 3) / (45 - 3.5) << endl;";
            else if (array1[4] == 3)
                this.code1_3.GetComponent<Text>().text = "cout << (10.5 + 2 * 3) / (45 - 3.5) << endl;";
            else if (array1[4] == 4)
                this.code1_4.GetComponent<Text>().text = "cout << (10.5 + 2 * 3) / (45 - 3.5) << endl;";
            else if (array1[4] == 5)
                this.code1_5.GetComponent<Text>().text = "cout << (10.5 + 2 * 3) / (45 - 3.5) << endl;";

            if (array1[5] == 0)
                this.code1_0.GetComponent<Text>().text = "return 0;";
            else if (array1[5] == 1)
                this.code1_1.GetComponent<Text>().text = "return 0;";
            else if (array1[5] == 2)
                this.code1_2.GetComponent<Text>().text = "return 0;";
            else if (array1[5] == 3)
                this.code1_3.GetComponent<Text>().text = "return 0;";
            else if (array1[5] == 4)
                this.code1_4.GetComponent<Text>().text = "return 0;";
            else if (array1[5] == 5)
                this.code1_5.GetComponent<Text>().text = "return 0;";

            this.code1Count++;
        }


    }
}
