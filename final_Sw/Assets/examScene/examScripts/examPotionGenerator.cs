using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class examPotionGenerator : MonoBehaviour
{
    public GameObject potionPrefab;
    float span = 4.0f;
    float delta = 0;
    //float timeOut = 3.0f;

    float[] potionPositionX = {21,40,77,14,40,84};
    float[] potionPositionY = {0,1,1,-3,-3.5f,1};

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta>this.span){
            this.delta = 0;
            GameObject go = Instantiate(potionPrefab) as GameObject;
            int px = Random.Range(0,6);
            go.transform.position = new Vector3(potionPositionX[px], potionPositionY[px],0);
        }
        
    }
}
