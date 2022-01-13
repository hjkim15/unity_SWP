using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeGenerator : MonoBehaviour
{
    public static CodeGenerator instance = null;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            if(instance != this)
                Destroy(this.gameObject);
        }
    }

    public GameObject code0_0;
    public GameObject code0_1;
    public GameObject code0_2;
    public GameObject code0_3;
    public GameObject code0_4;

    public GameObject code1_0;
    public GameObject code1_1;
    public GameObject code1_2;
    public GameObject code1_3;
    public GameObject code1_4;
    public GameObject code1_5;

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

    public int[] array0 = new int[5];

    void Start()
    {
        this.code0_0 = GameObject.Find("code0_0");
        this.code0_1 = GameObject.Find("code0_1");
        this.code0_2 = GameObject.Find("code0_2");
        this.code0_3 = GameObject.Find("code0_3");
        this.code0_4 = GameObject.Find("code0_4");

        this.code1_0 = GameObject.Find("code1_0");
        this.code1_1 = GameObject.Find("code1_1");
        this.code1_2 = GameObject.Find("code1_2");
        this.code1_3 = GameObject.Find("code1_3");
        this.code1_4 = GameObject.Find("code1_4");
        this.code1_5 = GameObject.Find("code1_5");

        this.code2_0 = GameObject.Find("code2_0");
        this.code2_1 = GameObject.Find("code2_1");
        this.code2_2 = GameObject.Find("code2_2");
        this.code2_3 = GameObject.Find("code2_3");
        this.code2_4 = GameObject.Find("code2_4");
        this.code2_5 = GameObject.Find("code2_5");
        this.code2_6 = GameObject.Find("code2_6");
        this.code2_7 = GameObject.Find("code2_7");
        this.code2_8 = GameObject.Find("code2_8");

        int rand0 = Random.Range(0, 5);

        array0[0] = rand0;
        array0[1] = (rand0 + 3) % 5;
        array0[2] = (rand0 + 2) % 5;
        array0[3] = (rand0 + 4) % 5;
        array0[4] = (rand0 + 1) % 5;

       
         if (array0[0] == 0)
             this.code0_0.GetComponent<Text>().text = "#include <iostream>";
         else if (array0[0] == 1)
             this.code0_1.GetComponent<Text>().text = "#include <iostream>";
         else if (array0[0] == 2)
             this.code0_2.GetComponent<Text>().text = "#include <iostream>";
         else if (array0[0] == 3)
             this.code0_3.GetComponent<Text>().text = "#include <iostream>";
         else if (array0[0] == 4)
             this.code0_4.GetComponent<Text>().text = "#include <iostream>";

         if (array0[1] == 0)
             this.code0_0.GetComponent<Text>().text = "using namespace std;";
         else if (array0[1] == 1)
             this.code0_1.GetComponent<Text>().text = "using namespace std;";
         else if (array0[1] == 2)
             this.code0_2.GetComponent<Text>().text = "using namespace std;";
         else if (array0[1] == 3)
             this.code0_3.GetComponent<Text>().text = "using namespace std;";
         else if (array0[1] == 4)
             this.code0_4.GetComponent<Text>().text = "using namespace std;";

         if (array0[2] == 0)
             this.code0_0.GetComponent<Text>().text = "main function";
         else if (array0[2] == 1)
             this.code0_1.GetComponent<Text>().text = "main function";
         else if (array0[2] == 2)
             this.code0_2.GetComponent<Text>().text = "main function";
         else if (array0[2] == 3)
             this.code0_3.GetComponent<Text>().text = "main function";
         else if (array0[2] == 4)
             this.code0_4.GetComponent<Text>().text = "main function";

         if (array0[3] == 0)
             this.code0_0.GetComponent<Text>().text = "cout << \"Welcome to C++!\" << endl;";
         else if (array0[3] == 1)
             this.code0_1.GetComponent<Text>().text = "cout << \"Welcome to C++!\" << endl;";
         else if (array0[3] == 2)
             this.code0_2.GetComponent<Text>().text = "cout << \"Welcome to C++!\" << endl;";
         else if (array0[3] == 3)
             this.code0_3.GetComponent<Text>().text = "cout << \"Welcome to C++!\" << endl;";
         else if (array0[3] == 4)
             this.code0_4.GetComponent<Text>().text = "cout << \"Welcome to C++!\" << endl;";

         if (array0[4] == 0)
             this.code0_0.GetComponent<Text>().text = "return 0;";
         else if (array0[4] == 1)
             this.code0_1.GetComponent<Text>().text = "return 0;";
         else if (array0[4] == 2)
             this.code0_2.GetComponent<Text>().text = "return 0;";
         else if (array0[4] == 3)
             this.code0_3.GetComponent<Text>().text = "return 0;";
         else if (array0[4] == 4)
             this.code0_4.GetComponent<Text>().text = "return 0;";    
         
        if (SupermanController.instance.code1Count != 1)
         {
             this.code1_0.GetComponent<Text>().text = "";
             this.code1_1.GetComponent<Text>().text = "";
             this.code1_2.GetComponent<Text>().text = "";
             this.code1_3.GetComponent<Text>().text = "";
             this.code1_4.GetComponent<Text>().text = "";
             this.code1_5.GetComponent<Text>().text = ""; 
         }
         if (Superman1Controller.instance.code2Count != 1)
         {
             this.code2_0.GetComponent<Text>().text = "";
             this.code2_1.GetComponent<Text>().text = "";
             this.code2_2.GetComponent<Text>().text = "";
             this.code2_3.GetComponent<Text>().text = "";
             this.code2_4.GetComponent<Text>().text = "";
             this.code2_5.GetComponent<Text>().text = "";
             this.code2_6.GetComponent<Text>().text = "";
             this.code2_7.GetComponent<Text>().text = "";
             this.code2_8.GetComponent<Text>().text = "";
         }
         
        }
    

    void Update()
    {
        
     
    }
}


