using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class examPotionController : MonoBehaviour
{
    private GameObject target;
    // float[] potionPosition = new Vector2[6,2];
    // float[] potionPositionX = {21,40,77,14,40,84};
    // float[] potionPositionY = {0,1,1,-3,-3.5f,1};

    GameObject time;
    GameObject libSit;

    float span = 3.0f;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        this.time = GameObject.Find("Time");
        //potionPosition[,] = {{21,0},{40,1},{77,1},{14,-3},{40,-3.5f},{84,1}};
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span){
            this.delta = 0;
            // Debug.Log(this.gameObject.collider
            Destroy(gameObject);
        }
    }

    // void FixedUpdate(){
    //     if(Input.GetMouseButtonDown(0)){
    //         CastRay();
    //         if(target==this.gameObject){
    //             this.gameObject.GetComponent<examTimerController>().increaseTime();
    //             Destroy(gameObject);
    //             }
    //             //시간 늘려줌.
    //     }
    // }
    // void CastRay(){
    //     target = null;
    //     Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //     RaycastHit2D hit = Physics2D.Raycast(pos,Vector2.zero,0f);

    //     if(hit.collider != null){
    //         //Debug.Log(hit.collider.name +"이름 출력"); //선택된 오브젝트 넘겨주기.
    //         target = hit.collider.gameObject;}
    // }

    

}
