using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class examListUIController : MonoBehaviour //아이템 찾으면 해당 위치에 체크 표시 해야 한다. 
{
    GameObject Director;
    int rowN;
    bool check = false;
    GameObject[] mark = new GameObject[6];
    // Start is called before the first frame update
    void Start()
    {
        Director = GameObject.Find("testDirector");
        for(int i=0;i<6;i++){
            mark[i] = GameObject.Find(i.ToString());
            mark[i].SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.check != false){ //여기에 체크 마크 생성. 
            //Debug.Log("체크를 할 위치는: " + rowN.ToString()); 
            mark[rowN].SetActive(true);
            this.check = false;
        }
        
        // string[] itemList = new string[4];
        // itemList = Director.GetComponent<examTestController>().GetFoundItem();
        // for()
        //Debug.Log("examListUI 체크. 아이템 리스트: "+itemList[0] +itemList[1] +itemList[2] +itemList[3] );
        //Debug.Log("")
    }

    public void checkFoundItem(int i){
        this.check = true;
        this.rowN = i;
    } 

    
}
