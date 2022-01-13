using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MTTextController : MonoBehaviour
{
    public int cnt = 0;
    GameObject comp;

    public AudioClip success;
    public AudioClip fail;
    public AudioClip check;
    AudioSource aud;

    public float rotate = 0;

    public void ClickBtn()
    {

        GameObject clickObject = EventSystem.current.currentSelectedGameObject; // 방금 클릭한 게임 오브젝트의 이름과 버튼 속 문자 출력
        //clickObject.GetComponentInChildren<TextMeshProUGUI>().text = "가";
        

        if (cnt == 0)
        {
            clickObject.GetComponentInChildren<TextMeshProUGUI>().fontSize = 70;
            comp = clickObject;
            cnt++;
        }
        else
        {
            if (comp.name != clickObject.name)
            {
                comp.GetComponentInChildren<TextMeshProUGUI>().fontSize = 50;
                cnt = 0;
                return;
            }
            clickObject.GetComponentInChildren<TextMeshProUGUI>().fontSize = 50;
            GameObject.Find("GameDirector").GetComponent<MTGameDirector>().game(clickObject.GetComponentInChildren<TextMeshProUGUI>().text);
            this.aud = GetComponent<AudioSource>();
            this.aud.PlayOneShot(this.check);
            //Invoke("IncreaseRotate", 1);
            cnt = 0;
        }
    }

    //retry button
    public void ClickBtn2()
    {
        GameObject.Find("GameDirector").GetComponent<MTGameDirector>().regame();
        Debug.Log("RE");
    }

    //check button
    public void ClickBtn3()
    {
        this.aud = GetComponent<AudioSource>();
        bool result = GameObject.Find("GameDirector").GetComponent<MTGameDirector>().checkgame();

        if (result)
        {
            this.aud.PlayOneShot(this.success);
            GameObject.Find("GameDirector").GetComponent<MTGameDirector>().correct++;
            GameObject.Find("GameDirector").GetComponent<MTGameDirector>().now++;
            GameObject.Find("GameDirector").GetComponent<MTGameDirector>().makequestion();
            GameObject.Find("GameDirector").GetComponent<MTGameDirector>().regame();
        }
        else
        {
            this.aud.PlayOneShot(this.fail);
            GameObject.Find("GameDirector").GetComponent<MTGameDirector>().correct--;
            GameObject.Find("GameDirector").GetComponent<MTGameDirector>().regame();
        }
        Debug.Log(GameObject.Find("GameDirector").GetComponent<MTGameDirector>().now+", "+ GameObject.Find("GameDirector").GetComponent<MTGameDirector>().check);
    }

    void increaseRotate() {
        rotate += 10.0f;
        //transform.position.rotation = new Vector3(transform.position.rotation.x, rotate, transform.position.rotation.z);
    }
}
