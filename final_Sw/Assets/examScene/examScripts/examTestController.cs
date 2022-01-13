using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//https://m.blog.naver.com/PostView.naver?isHttpsRedirect=true&blogId=ateliersera&logNo=220439790504 
public class examTestController : MonoBehaviour
{
    private GameObject target;
    int cameraPosition;
    GameObject bookshelf;
    GameObject desk;
    GameObject imac;
    GameObject drawer;
    GameObject ListUI;
    GameObject TimerUI;
    GameObject background;
    //GameObject Director;
    // GameObject fileName;
    
    bool TimeOver;
    //Camera examCamera;
    string[] itemList = {"airpod","battery","book","C++.docx","Java.docx","pen", "pencil", "Python.docx","rubber","tissue","whiteout"}; //file 추가.
    // string[] itemList = {"pen", "pencil", "rubber", "whiteout", "tissue", "airpod", "battery","book","docx_1","docx_2" }; //file 추가.
    string[] selectedItemList = new string[6]; //랜덤으로 찾을 아이템 6개. 
    string[] foundItemList = new string[6]; //찾은 아이템.
    int foundItemNumber = 0; //찾은 아이템 개수
   // string[] selectedFile = new string[2];
   // string[] fileList = {"SQL", "C#", "Python", "R", "C++", "Java"};
    // string[] fileList = {"SQL.docx", "C#.docx", "Python.docx", "R.docx", "C++.docx", "Java.docx"};

//file 배열{3,4,5,8,9,11};


    void selectRandItem(){
        int[] arr = getRandomInt(6,0,11);
        for(int i = 0;i<6;i++){
            this.selectedItemList[i] = itemList[arr[i]];
        }
    //     int[] arr = getRandomInt(3,0,7);
    //     int[] arr2 = getRandomInt(3,7,14);
    //    // arr = arr+arr2;
    //     // for(int i = 0;i<6;i++)
    //     //     Debug.Log(arr[i]);
    //     for(int i = 0; i< 3; i++){
    //         //Debug.Log("randItem select :       " + itemList[arr[i]]);
    //         this.selectedItemList[i] = itemList[arr[i]]; //랜덤 아이템 선택하기.
            
    //         //this.leftItem[i] = itemList[arr[i]];
    //     }
    //     for(int j = 3; j<6;j++){
    //         this.selectedItemList[j] = itemList[arr2[j]];
    //     }

        //Debug.Log("randomItem selection list: "+selectedItemList[0]+ "  " +selectedItemList[1]+ "  "+selectedItemList[2]+ "  "+selectedItemList[3]);
    }

    // void selectRandFile(){
    //     int[] arr = getRandomInt(2,0,6);
    //     for(int i = 0;i<2; i++){
    //         this.selectedFile[i] = fileList[arr[i]];
    //     }
    // }

    // public string[] GetSelectedFile(){
    //     return selectedFile;
    // }

    public string[] GetSelectedItemList(){
        return selectedItemList;
    }

    public int[] getRandomInt(int length, int min, int max){ //중복 없는 랜덤값 생성
        int[] randArray = new int[length];
        bool isSame;
        for(int i = 0; i< length; ++i){
            while(true){
                randArray[i] = Random.Range(min,max);
                isSame = false;
                for(int j = 0; j<i;++j){
                    if(randArray[j] == randArray[i]){
                        isSame = true;
                        break;
                    }
                } 
                if(!isSame) break;
            }
        }
        return randArray;
    }

    public int getCameraPosition(){
        return cameraPosition;
    }
    public void setCameraPosition(int n){
        cameraPosition = n;
    }

    void FixedUpdate(){
        if(Input.GetMouseButtonDown(0)){
            CastRay();
            CheckPlace();
            //if(target==this.gameObject){ //이 스크립트를 각 오브젝트에 설정했을 때.
              //  Debug.Log("이게 뭐지");
                //카메라 이동해줘야. 
                // this.cameraPosition = 20;
            //}
            if(this.foundItemNumber == 6){
                //Debug.Log("아이템 전부 다 찾음.");
                //Debug.Log("찾은 아이템: " + foundItemList[0] + " " + foundItemList[1] + " " + foundItemList[2] + " " +foundItemList[3]);
                TimerUI.GetComponent<examTimerController>().foundAllItem();
            }
        }
    }

    void CastRay(){
        target = null;
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(pos,Vector2.zero,0f);

        if(hit.collider != null){
            //Debug.Log(hit.collider.name +"이름 출력"); //선택된 오브젝트 넘겨주기.
            target = hit.collider.gameObject;
            //string tagN = hit.collider.gameObject.tag;
           // Debug.Log(tagN);
            // if(this.foundItemNumber == 6){
            //     Debug.Log("아이템 전부 다 찾음.");
            //     Debug.Log("찾은 아이템: " + foundItemList[0] + " " + foundItemList[1] + " " + foundItemList[2] + " " +foundItemList[3]);
            //     TimerUI.GetComponent<examTimerController>().foundAllItem();
            // }
            if(this.foundItemNumber<6 && !this.TimeOver){
                // if(this.hit.collider.name==)
                //if(this.hit.collider.name == "")
                CheckItem(hit.collider.name);
                if( hit.collider.gameObject.tag == "Potion"){ //커피 인식.
                    Debug.Log("성공!!!!!!!!!!!!!!!1");
                    TimerUI.GetComponent<examTimerController>().increaseTime();
                    //좌석 일시정지 시키기.
                    Destroy(target);

                }
                if(hit.collider.name =="finder"){
                    gameObject.GetComponent<examButtonController>().closeFinder();
                }
                //if()
                }
        }
    }

    void CheckItem(string n){
        string targetName = n;
        //Debug.Log(targetName + "이름 스트링으로 변환 성공");
        
        for(int i = 0;i<6;i++){
            if(selectedItemList[i] == targetName){ //찾은 리스트에 넣어야. 
                Debug.Log(targetName + "비교 성공");
                //this.foundItemList[this.foundItemNumber] = targetName;
                //this.foundItemList[foundItemNumber] = targetName;
                //background.GetComponent<AudioSource>().volume = 0.1f;
                GetComponent<AudioSource>().Play();
                 //background.GetComponent<AudioSource>().volume = 0.7f;
                 SetFoundItem(targetName,i);
                //Debug.Log("foundItemList 잘 되나 확인" + this.foundItemList[this.foundItemNumber]);
                 this.foundItemNumber++;
                Debug.Log("foundItem Number "+foundItemNumber.ToString());
                // fileName.GetComponent<Text>().text = "";
                Destroy(target);    
            }
            // else if(targetName=="coffeemix(Clone)"){
            // else if(other.gameObject.tag =="Potion"){
            //     this.gameObject.GetComponent<examTimerController>().increaseTime();
            //     Debug.Log("커피 비교 성공");
            // }
        }
        
    }
    void SetFoundItem(string n, int i){ //넣을 아이템 이름, 넣을 배열 위치
        this.foundItemList[i] = n;
        Debug.Log(foundItemList[i]);
        //this.foundItemNumber ++;
        Debug.Log("foundItemList 잘 되나 확인  " + this.foundItemList[i]);
        ListUI.GetComponent<examListUIController>().checkFoundItem(i);
    }

    public string[] GetFoundItem(){
        return this.foundItemList;
    }

    void CheckPlace(){
        if(target == desk){
           Debug.Log("bookshelf 찾음");
            this.cameraPosition = 20;
        }
        else if(target == bookshelf){
            Debug.Log("desk 찾음");
            this.cameraPosition = 40;
        }
        else if(target == imac){
            Debug.Log("imac 찾음");
            this.cameraPosition = 60;
            gameObject.GetComponent<examButtonController>().setButton(true);
        }
        else if(target == drawer){
            Debug.Log("drawer 찾음");
            this.cameraPosition = 80;
        }
        // else{
        //     //클릭 안됨. 아무런 이동 없음.
        //     this.cameraPosition = this.cameraPosition;
        // }
        
    }


    void Start(){
        bookshelf = GameObject.Find("bookshelf");
        desk = GameObject.Find("desk");
        imac = GameObject.Find("imac");
        drawer = GameObject.Find("drawer");
        ListUI = GameObject.Find("itemListPaper"); //이거 체크로 바꿔야 함. 
        TimerUI = GameObject.Find("Time");
        background = GameObject.Find("background_exam");
       
        // this.aud = GetComponent<AudioSource>();
        // Button = gameObject.GetComponent<examButtonController>();
        //TimeOver = GameObject.Find("Time").GetComponent<examTimerController>().isTimeOver();
        //examCamera = GameObject.Find("MainCamera");
        selectRandItem();
        //Debug.Log(itemList[1]);
        // fileName = GameObject.Find("fileName");
    }
    void Update(){
        
    }

    public void isTimeOver(){
        this.TimeOver = true;
    }
   
}
