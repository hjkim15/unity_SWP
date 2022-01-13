using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class examCameraController : MonoBehaviour
{
    GameObject bookshelf;
    GameObject testDirector;
    GameObject backButton;
    GameObject Director;

    //int cameraPosition = 0;
    // Start is called before the first frame update
    void Start()
    {
        bookshelf = GameObject.Find("bookshelf");
        testDirector = GameObject.Find("testDirector");
        backButton = GameObject.Find("backButton");
        Director = GameObject.Find("testDirector");
    }
    // Update is called once per frame
    void Update()
    {
        //if(Input.GetMouseButtonDown(0)){
            //int cameraPosition = bookshelf.GetComponent<examTestController>().getCameraPosition();
            //if(cameraPosition==1){
            int cameraPosition = testDirector.GetComponent<examTestController>().getCameraPosition();
            transform.position = new Vector3(cameraPosition,0,-10);
            
        //}
        if(transform.position.x==0) //여기에 짜면 안되는 코드... examTestController로 옮기기
            backButton.SetActive(false);
        else
            backButton.SetActive(true);
        // if(cameraPosition == 60){ //파일들 보이게.
        //     Director.GetComponent<examButtonController>().setButton(true);
        // }
    }
    
    // public void pushButton(){
    //     if(transform.position.x!=0){
    //     transform.position = new Vector3(0,0,-10);
    //     testDirector.GetComponent<examTestController>().setCameraPosition(0);
    //     //backButton.SetActive(false);
    //     }
    // }

    
}
