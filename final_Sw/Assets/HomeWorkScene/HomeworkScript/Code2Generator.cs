using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Code2Generator : MonoBehaviour
{
    public static Code2Generator instance = null;

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

    public GameObject code2_0;
    public GameObject code2_1;
    public GameObject code2_2;
    public GameObject code2_3;
    public GameObject code2_4;
    public GameObject code2_5;
    public GameObject code2_6;
    public GameObject code2_7;
    public GameObject code2_8;

    int count;
    int code2Count;

    public int[] array2 = new int[9];

    void Start()
    {
        this.code2_0 = GameObject.Find("code2_0");
        this.code2_1 = GameObject.Find("code2_1");
        this.code2_2 = GameObject.Find("code2_2");
        this.code2_3 = GameObject.Find("code2_3");
        this.code2_4 = GameObject.Find("code2_4");
        this.code2_5 = GameObject.Find("code2_5");
        this.code2_6 = GameObject.Find("code2_6");
        this.code2_7 = GameObject.Find("code2_7");
        this.code2_8 = GameObject.Find("code2_8");

        int rand2 = Random.Range(0, 9);
        this.code2Count = 0;

        array2[0] = rand2;
        array2[1] = (rand2 + 7) % 9;
        array2[2] = (rand2 + 2) % 9;
        array2[3] = (rand2 + 4) % 9;
        array2[4] = (rand2 + 1) % 9;
        array2[5] = (rand2 + 6) % 9;
        array2[6] = (rand2 + 3) % 9;
        array2[7] = (rand2 + 8) % 9;
        array2[8] = (rand2 + 5) % 9;
    }


    void Update()
    {
        if (Superman1Controller.instance.code2Count == 1 && this.code2Count == 0)
        {
            if (array2[0] == 0)
                this.code2_0.GetComponent<Text>().text = "#include <iostream>";
            else if (array2[0] == 1)
                this.code2_1.GetComponent<Text>().text = "#include <iostream>";
            else if (array2[0] == 2)
                this.code2_2.GetComponent<Text>().text = "#include <iostream>";
            else if (array2[0] == 3)
                this.code2_3.GetComponent<Text>().text = "#include <iostream>";
            else if (array2[0] == 4)
                this.code2_4.GetComponent<Text>().text = "#include <iostream>";
            else if (array2[0] == 5)
                this.code2_5.GetComponent<Text>().text = "#include <iostream>";
            else if (array2[0] == 6)
                this.code2_6.GetComponent<Text>().text = "#include <iostream>";
            else if (array2[0] == 7)
                this.code2_7.GetComponent<Text>().text = "#include <iostream>";
            else if (array2[0] == 8)
                this.code2_8.GetComponent<Text>().text = "#include <iostream>";


            if (array2[1] == 0)
                this.code2_0.GetComponent<Text>().text = "using namespace std;";
            else if (array2[1] == 1)
                this.code2_1.GetComponent<Text>().text = "using namespace std;";
            else if (array2[1] == 2)
                this.code2_2.GetComponent<Text>().text = "using namespace std;";
            else if (array2[1] == 3)
                this.code2_3.GetComponent<Text>().text = "using namespace std;";
            else if (array2[1] == 4)
                this.code2_4.GetComponent<Text>().text = "using namespace std;";
            else if (array2[1] == 5)
                this.code2_5.GetComponent<Text>().text = "using namespace std;";
            else if (array2[1] == 6)
                this.code2_6.GetComponent<Text>().text = "using namespace std;";
            else if (array2[1] == 7)
                this.code2_7.GetComponent<Text>().text = "using namespace std;";
            else if (array2[1] == 8)
                this.code2_8.GetComponent<Text>().text = "using namespace std;";


            if (array2[2] == 0)
                this.code2_0.GetComponent<Text>().text = "main function";
            else if (array2[2] == 1)
                this.code2_1.GetComponent<Text>().text = "main function";
            else if (array2[2] == 2)
                this.code2_2.GetComponent<Text>().text = "main function";
            else if (array2[2] == 3)
                this.code2_3.GetComponent<Text>().text = "main function";
            else if (array2[2] == 4)
                this.code2_4.GetComponent<Text>().text = "main function";
            else if (array2[2] == 5)
                this.code2_5.GetComponent<Text>().text = "main function";
            else if (array2[2] == 6)
                this.code2_6.GetComponent<Text>().text = "main function";
            else if (array2[2] == 7)
                this.code2_7.GetComponent<Text>().text = "main function";
            else if (array2[2] == 8)
                this.code2_8.GetComponent<Text>().text = "main function";

            if (array2[3] == 0)
                this.code2_0.GetComponent<Text>().text = "double radius;";
            else if (array2[3] == 1)
                this.code2_1.GetComponent<Text>().text = "double radius;";
            else if (array2[3] == 2)
                this.code2_2.GetComponent<Text>().text = "double radius;";
            else if (array2[3] == 3)
                this.code2_3.GetComponent<Text>().text = "double radius;";
            else if (array2[3] == 4)
                this.code2_4.GetComponent<Text>().text = "double radius;";
            else if (array2[3] == 5)
                this.code2_5.GetComponent<Text>().text = "double radius;";
            else if (array2[3] == 6)
                this.code2_6.GetComponent<Text>().text = "double radius;";
            else if (array2[3] == 7)
                this.code2_7.GetComponent<Text>().text = "double radius;";
            else if (array2[3] == 8)
                this.code2_8.GetComponent<Text>().text = "double radius;";

            if (array2[4] == 0)
                this.code2_0.GetComponent<Text>().text = "double area;";
            else if (array2[4] == 1)
                this.code2_1.GetComponent<Text>().text = "double area;";
            else if (array2[4] == 2)
                this.code2_2.GetComponent<Text>().text = "double area;";
            else if (array2[4] == 3)
                this.code2_3.GetComponent<Text>().text = "double area;";
            else if (array2[4] == 4)
                this.code2_4.GetComponent<Text>().text = "double area;";
            else if (array2[4] == 5)
                this.code2_5.GetComponent<Text>().text = "double area;";
            else if (array2[4] == 6)
                this.code2_6.GetComponent<Text>().text = "double area;";
            else if (array2[4] == 7)
                this.code2_7.GetComponent<Text>().text = "double area;";
            else if (array2[4] == 8)
                this.code2_8.GetComponent<Text>().text = "double area;";

            if (array2[5] == 0)
                this.code2_0.GetComponent<Text>().text = "radius = 20;";
            else if (array2[5] == 1)
                this.code2_1.GetComponent<Text>().text = "radius = 20;";
            else if (array2[5] == 2)
                this.code2_2.GetComponent<Text>().text = "radius = 20;";
            else if (array2[5] == 3)
                this.code2_3.GetComponent<Text>().text = "radius = 20;";
            else if (array2[5] == 4)
                this.code2_4.GetComponent<Text>().text = "radius = 20;";
            else if (array2[5] == 5)
                this.code2_5.GetComponent<Text>().text = "radius = 20;";
            else if (array2[5] == 6)
                this.code2_6.GetComponent<Text>().text = "radius = 20;";
            else if (array2[5] == 7)
                this.code2_7.GetComponent<Text>().text = "radius = 20;";
            else if (array2[5] == 8)
                this.code2_8.GetComponent<Text>().text = "radius = 20;";

            if (array2[6] == 0)
                this.code2_0.GetComponent<Text>().text = "area = radius * radius * 3.14159;";
            else if (array2[6] == 1)
                this.code2_1.GetComponent<Text>().text = "area = radius * radius * 3.14159;";
            else if (array2[6] == 2)
                this.code2_2.GetComponent<Text>().text = "area = radius * radius * 3.14159;";
            else if (array2[6] == 3)
                this.code2_3.GetComponent<Text>().text = "area = radius * radius * 3.14159;";
            else if (array2[6] == 4)
                this.code2_4.GetComponent<Text>().text = "area = radius * radius * 3.14159;";
            else if (array2[6] == 5)
                this.code2_5.GetComponent<Text>().text = "area = radius * radius * 3.14159;";
            else if (array2[6] == 6)
                this.code2_6.GetComponent<Text>().text = "area = radius * radius * 3.14159;";
            else if (array2[6] == 7)
                this.code2_7.GetComponent<Text>().text = "area = radius * radius * 3.14159;";
            else if (array2[6] == 8)
                this.code2_8.GetComponent<Text>().text = "area = radius * radius * 3.14159;";

            if (array2[7] == 0)
                this.code2_0.GetComponent<Text>().text = "cout << \"The area is \" << area << endl;";
            else if (array2[7] == 1)
                this.code2_1.GetComponent<Text>().text = "cout << \"The area is \" << area << endl;";
            else if (array2[7] == 2)
                this.code2_2.GetComponent<Text>().text = "cout << \"The area is \" << area << endl;";
            else if (array2[7] == 3)
                this.code2_3.GetComponent<Text>().text = "cout << \"The area is \" << area << endl;";
            else if (array2[7] == 4)
                this.code2_4.GetComponent<Text>().text = "cout << \"The area is \" << area << endl;";
            else if (array2[7] == 5)
                this.code2_5.GetComponent<Text>().text = "cout << \"The area is \" << area << endl;";
            else if (array2[7] == 6)
                this.code2_6.GetComponent<Text>().text = "cout << \"The area is \" << area << endl;";
            else if (array2[7] == 7)
                this.code2_7.GetComponent<Text>().text = "cout << \"The area is \" << area << endl;";
            else if (array2[7] == 8)
                this.code2_8.GetComponent<Text>().text = "cout << \"The area is \" << area << endl;";

            if (array2[8] == 0)
                this.code2_0.GetComponent<Text>().text = "return 0;";
            else if (array2[8] == 1)
                this.code2_1.GetComponent<Text>().text = "return 0;";
            else if (array2[8] == 2)
                this.code2_2.GetComponent<Text>().text = "return 0;";
            else if (array2[8] == 3)
                this.code2_3.GetComponent<Text>().text = "return 0;";
            else if (array2[8] == 4)
                this.code2_4.GetComponent<Text>().text = "return 0;";
            else if (array2[8] == 5)
                this.code2_5.GetComponent<Text>().text = "return 0;";
            else if (array2[8] == 6)
                this.code2_6.GetComponent<Text>().text = "return 0;";
            else if (array2[8] == 7)
                this.code2_7.GetComponent<Text>().text = "return 0;";
            else if (array2[8] == 8)
                this.code2_8.GetComponent<Text>().text = "return 0;";

            this.code2Count++;

        }

    }
}
