using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class examUIController : MonoBehaviour
{
    string[] itemList;
    // Start is called before the first frame update
    void Start()
    {
        itemList = GameObject.Find("testDirector").GetComponent<examTestController>().GetSelectedItemList();
        
    }

    // Update is called once per frame
    void Update()
    {
        // for(int i = 0;i<6;i++){
            
        // this.GetComponent<Text>().text = itemList[0] + "\n" + itemList[1] + "\n" + itemList[2] + "\n" +itemList[3];}
        this.GetComponent<Text>().text = itemList[0] + "\n" + itemList[1] + "\n" + itemList[2] + "\n" +itemList[3]+ "\n" +itemList[4]+ "\n" +itemList[5] ;
    }
}
