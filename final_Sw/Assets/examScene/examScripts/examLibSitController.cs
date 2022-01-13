using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.UI;

public class examLibSitController : MonoBehaviour
{
    // GameObject[] libSitLeft = new GameObject[30];
    //GameObject[] libSitRight = new GameObject[30];
    int[] libSitLeftO = new int[30];
    int[] libSitRightO = new int[30];
    //GameObject Time;
    //GameObject Director;
    // float time = 30.0f;
    // float span = 1.0f;
    // float delta = 1;
    GameObject Director;
    //int count = 0;
   // int val1, val2;
    int deleteCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        Director = GameObject.Find("testDirector");
        libSitRightO = Director.GetComponent<examTestController>().getRandomInt(30,20,50);
        libSitLeftO = Director.GetComponent<examTestController>().getRandomInt(30,50,80);
        //Time = GameObject.Find("Time");
       
       // Director = GameObject.Find("testDirector");
        
    }

    // Update is called once per frame
    void Update()
    {
        //this.time -= Time.deltaTime;
        // this.delta += Time.deltaTime;
        // if(this.delta>this.span){
        //     this.delta = 0;
        //     OccupySit(this.count);
        //     this.count++;
        // }
        
        
    }

    public void OccupySit(int i){
        // if(obj){
        // if(i==30){
        //     deleteCount = i;
        // }
        if(this.deleteCount<=i){
            GameObject D1 = GameObject.Find((libSitRightO[i]).ToString());
            Destroy(D1);

            GameObject D2 = GameObject.Find((libSitLeftO[i]).ToString());
            Destroy(D2);
        
            this.deleteCount = i;
           // Debug.Log(deleteCount + " deleteCount libsit controller occupysit");
        }
        else{
            ;
        }
        }
        // else{
        //     ;
        // }
        //libSitLeft[(val2-50)].SetActive(true);
     
}
