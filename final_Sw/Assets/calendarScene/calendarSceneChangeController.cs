using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//씬 전환 스크립트. 특정 달에 특정 일을 선택하면 바뀌도록. 
public class calendarSceneChangeController : MonoBehaviour
{
    private GameObject target;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // void FixedUpdate(){
    //     if(Input.GetMouseButtonDown(0)){
    //         CastRay();
    //     }
    // }

    // void CastRay(){
    //     target = null;
    //     Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //     RaycastHit2D hit = Physics2D.Raycast(pos,Vector2.zero,0f);

    //     if(hit.collider != null){
    //         target = hit.collider.gameObject;
    //         Debug.Log (hit.collider.name);
    //         if(hit.collider.name == "19"){
    //             SceneManager.LoadScene("examScene");
    //         }
    //     }
    // }

    public void examButton(){
        SceneManager.LoadScene("examScene");
    }

    public void changeSceneButton(int t)
    {
        calendarAudioManager.instance.AudioDestroy();
        switch (t)
        {
            case 1: //통학. 3/1. 3번
                SceneManager.LoadScene("commute");
                break;
            case 7: //알바. 4/7 12번
                SceneManager.LoadScene("InitialScene");
                break;
            case 13: //시험. 6/13 16번
                SceneManager.LoadScene("examScene");
                break;
            case 16: //수강. 2/16 18번
                SceneManager.LoadScene("registerScene");
                break;
            case 18: //오티. 2/18 20번
                SceneManager.LoadScene("Quiz");
                break;
            case 21: //과제. 5/21 21번
                SceneManager.LoadScene("HomeworkScene");
                break;
            case 23: //종강. 6/23 26번
                SceneManager.LoadScene("endScene");
                break;
            case 25: //mt. 3/25  27번
                SceneManager.LoadScene("MTGame");
                break;
        }
    }
}
