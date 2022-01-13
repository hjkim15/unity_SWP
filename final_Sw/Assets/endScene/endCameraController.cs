using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class endCameraController : MonoBehaviour
{
    //https://hannom.tistory.com/181
    GameObject scroll;
    bool scrollD = true;

    // Start is called before the first frame update
    void Start()
    {
        // thisCamera = GetComponent<Camera>();
        this.scroll = GameObject.Find("scroll");
        StartCoroutine(blickText());
    }

    // Update is called once per frame
    void Update()
    {

        float wheelInput = Input.GetAxis("Mouse ScrollWheel");
        if (wheelInput > 0)
        {
            this.scrollD = false;
            // 휠을 밀어 돌렸을 때의 처리 ↑
            if (this.transform.position.y <= -6.8f)
            {
                this.transform.Translate(0, 0.2f, 0);
            }

        }
        else if (wheelInput < 0)
        {
            this.scrollD = false;
            // 휠을 당겨 올렸을 때의 처리 ↓
            if ((this.transform.position.y >= -21.2f))
            {
                this.transform.Translate(0, -0.2f, 0);
            }
        }

        //출처: https://wergia.tistory.com/117 [베르의 프로그래밍 노트]



    }
    IEnumerator blickText()
    {
        while (true)
        { //https://sosohanbox.tistory.com/159

            this.scroll.GetComponent<TextMeshProUGUI>().text = " ";
            yield return new WaitForSeconds(0.7f);
            if (this.scrollD == true)
            {
                this.scroll.GetComponent<TextMeshProUGUI>().text = "SCROLL";
            }
            yield return new WaitForSeconds(0.7f);

        }
    }
}