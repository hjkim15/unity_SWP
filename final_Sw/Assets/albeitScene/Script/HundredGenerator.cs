using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HundredGenerator : MonoBehaviour
{

    Vector2 MousePosition;
    Camera Camera;

    public GameObject hundredPrefab;
    public GameObject xPrefab;

    void Start()
    {
        Camera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MousePosition = Input.mousePosition;
            MousePosition = Camera.ScreenToWorldPoint(MousePosition);

            transform.position = MousePosition;
            Debug.Log(MousePosition);
        }

        if (DoYeonCupSizeDirector.instance.price == 1000)
        {
            GameObject hun = Instantiate(hundredPrefab) as GameObject;
            hun.transform.position = new Vector3(-7.0f, 3.2f, 0);
        }
        else
        {
            GameObject x = Instantiate(xPrefab) as GameObject;
            x.transform.position = new Vector3(-7.0f, 3.2f, 0);
        }
        if (DoYeonLiquidDirector.instance.price == 1000)
        {
            GameObject hun = Instantiate(hundredPrefab) as GameObject;
            hun.transform.position = new Vector3(-5.5f, 3.2f, 0);
        }
        else
        {
            GameObject x = Instantiate(xPrefab) as GameObject;
            x.transform.position = new Vector3(-5.5f, 3.2f, 0);
        }
        if (DoYeonSyrupDirector.instance.price == 1000)
        {
            GameObject hun = Instantiate(hundredPrefab) as GameObject;
            hun.transform.position = new Vector3(-4.1f, 3.2f, 0);
        }
        else
        {
            GameObject x = Instantiate(xPrefab) as GameObject;
            x.transform.position = new Vector3(-4.1f, 3.2f, 0);
        }
        if (DoYeonShotDirector.instance.price == 1000)
        {
            GameObject hun = Instantiate(hundredPrefab) as GameObject;
            hun.transform.position = new Vector3(-2.8f, 3.2f, 0);
        }
        else
        {
            GameObject x = Instantiate(xPrefab) as GameObject;
            x.transform.position = new Vector3(-2.8f, 3.2f, 0);
        }
        if (HeeJoCupSizeDirector.instance.price == 1000)
        {
            GameObject hun = Instantiate(hundredPrefab) as GameObject;
            hun.transform.position = new Vector3(-7.0f, 1.8f, 0);
        }
        else
        {
            GameObject x = Instantiate(xPrefab) as GameObject;
            x.transform.position = new Vector3(-7.0f, 1.8f, 0);
        }
        if (HeeJoLiquidDirector.instance.price == 1000)
        {
            GameObject hun = Instantiate(hundredPrefab) as GameObject;
            hun.transform.position = new Vector3(-5.5f, 1.8f, 0);
        }
        else
        {
            GameObject x = Instantiate(xPrefab) as GameObject;
            x.transform.position = new Vector3(-5.5f, 1.8f, 0);
        }
        if (HeeJoSyrupScene.instance.price == 1000)
        {
            GameObject hun = Instantiate(hundredPrefab) as GameObject;
            hun.transform.position = new Vector3(-4.1f, 1.8f, 0);
        }
        else
        {
            GameObject x = Instantiate(xPrefab) as GameObject;
            x.transform.position = new Vector3(-4.1f, 1.8f, 0);
        }
        if (HeeJoShotDirector.instance.price == 1000)
        {
            GameObject hun = Instantiate(hundredPrefab) as GameObject;
            hun.transform.position = new Vector3(-2.8f, 1.8f, 0);
        }
        else
        {
            GameObject x = Instantiate(xPrefab) as GameObject;
            x.transform.position = new Vector3(-2.8f, 1.8f, 0);
        }
        if (JiHyeCupSizeDirector.instance.price == 1000)
        {
            GameObject hun = Instantiate(hundredPrefab) as GameObject;
            hun.transform.position = new Vector3(-7.0f, 0.6f, 0);
        }
        else
        {
            GameObject x = Instantiate(xPrefab) as GameObject;
            x.transform.position = new Vector3(-7.0f, 0.6f, 0);
        }
        if (JiHyeLiquidDirector.instance.price == 1000)
        {
            GameObject hun = Instantiate(hundredPrefab) as GameObject;
            hun.transform.position = new Vector3(-5.5f, 0.6f, 0);
        }
        else
        {
            GameObject x = Instantiate(xPrefab) as GameObject;
            x.transform.position = new Vector3(-5.5f, 0.6f, 0);
        }
        if (JiHyeSyrupDirector.instance.price == 1000)
        {
            GameObject hun = Instantiate(hundredPrefab) as GameObject;
            hun.transform.position = new Vector3(-4.1f, 0.6f, 0);
        }
        else
        {
            GameObject x = Instantiate(xPrefab) as GameObject;
            x.transform.position = new Vector3(-4.1f, 0.6f, 0);
        }
        if (JiHyeShotDirector.instance.price == 1000)
        {
            GameObject hun = Instantiate(hundredPrefab) as GameObject;
            hun.transform.position = new Vector3(-2.8f, 0.6f, 0);
        }
        else
        {
            GameObject x = Instantiate(xPrefab) as GameObject;
            x.transform.position = new Vector3(-2.8f, 0.6f, 0);
        }
        if (MoonJungCupSizeDirector.instance.price == 1000)
        {
            GameObject hun = Instantiate(hundredPrefab) as GameObject;
            hun.transform.position = new Vector3(-7.0f, -0.8f, 0);
        }
        else
        {
            GameObject x = Instantiate(xPrefab) as GameObject;
            x.transform.position = new Vector3(-7.0f, -0.8f, 0);
        }
        if (MoonJungLiquidDirector.instance.price == 1000)
        {
            GameObject hun = Instantiate(hundredPrefab) as GameObject;
            hun.transform.position = new Vector3(-5.5f, -0.8f, 0);
        }
        else
        {
            GameObject x = Instantiate(xPrefab) as GameObject;
            x.transform.position = new Vector3(-5.5f, -0.8f, 0);
        }
        if (MoonJungSyrupDirector.instance.price == 1000)
        {
            GameObject hun = Instantiate(hundredPrefab) as GameObject;
            hun.transform.position = new Vector3(-4.1f, -0.8f, 0);
        }
        else
        {
            GameObject x = Instantiate(xPrefab) as GameObject;
            x.transform.position = new Vector3(-4.1f, -0.8f, 0);
        }
        if (MoonJungShotDirector.instance.price == 1000)
        {
            GameObject hun = Instantiate(hundredPrefab) as GameObject;
            hun.transform.position = new Vector3(-2.8f, -0.8f, 0);
        }
        else
        {
            GameObject x = Instantiate(xPrefab) as GameObject;
            x.transform.position = new Vector3(-2.8f, -0.8f, 0);
        }
        if (ByunCupSizeDirector.instance.price == 1000)
        {
            GameObject hun = Instantiate(hundredPrefab) as GameObject;
            hun.transform.position = new Vector3(-7.0f, -2.2f, 0);
        }
        else
        {
            GameObject x = Instantiate(xPrefab) as GameObject;
            x.transform.position = new Vector3(-7.0f, -2.2f, 0);
        }
        if (ByunLiquidDirector.instance.price == 1000)
        {
            GameObject hun = Instantiate(hundredPrefab) as GameObject;
            hun.transform.position = new Vector3(-5.5f, -2.2f, 0);
        }
        else
        {
            GameObject x = Instantiate(xPrefab) as GameObject;
            x.transform.position = new Vector3(-5.5f, -2.2f, 0);
        }
        if (ByunSyrupDirector.instance.price == 1000)
        {
            GameObject hun = Instantiate(hundredPrefab) as GameObject;
            hun.transform.position = new Vector3(-4.1f, -2.2f, 0);
        }
        else
        {
            GameObject x = Instantiate(xPrefab) as GameObject;
            x.transform.position = new Vector3(-4.1f, -2.2f, 0);
        }
        if (ByunShotDirector.instance.price == 1000)
        {
            GameObject hun = Instantiate(hundredPrefab) as GameObject;
            hun.transform.position = new Vector3(-2.8f, -2.2f, 0);
        }
        else
        {
            GameObject x = Instantiate(xPrefab) as GameObject;
            x.transform.position = new Vector3(-2.8f, -2.2f, 0);
        }
        if (ByunToppingDirector.instance.price == 1000)
        {
            GameObject hun = Instantiate(hundredPrefab) as GameObject;
            hun.transform.position = new Vector3(-1.4f, -2.2f, 0);
        }
        else
        {
            GameObject x = Instantiate(xPrefab) as GameObject;
            x.transform.position = new Vector3(-1.4f, -2.2f, 0);
        }
        if (ByunCreamDirector.instance.price == 1000)
        {
            GameObject hun = Instantiate(hundredPrefab) as GameObject;
            hun.transform.position = new Vector3(0.0f, -2.2f, 0);
        }
        else
        {
            GameObject x = Instantiate(xPrefab) as GameObject;
            x.transform.position = new Vector3(0.0f, -2.2f, 0);
        }
        if (HongCupSizeDirector.instance.price == 1000)
        {
            GameObject hun = Instantiate(hundredPrefab) as GameObject;
            hun.transform.position = new Vector3(-7.0f, -3.3f, 0);
        }
        else
        {
            GameObject x = Instantiate(xPrefab) as GameObject;
            x.transform.position = new Vector3(-7.0f, -3.3f, 0);
        }
        if (HongLiquidDirector.instance.price == 1000)
        {
            GameObject hun = Instantiate(hundredPrefab) as GameObject;
            hun.transform.position = new Vector3(-5.5f, -3.3f, 0);
        }
        else
        {
            GameObject x = Instantiate(xPrefab) as GameObject;
            x.transform.position = new Vector3(-5.5f, -3.3f, 0);
        }
        if (HongSyrupDirector.instance.price == 1000)
        {
            GameObject hun = Instantiate(hundredPrefab) as GameObject;
            hun.transform.position = new Vector3(-4.1f, -3.3f, 0);
        }
        else
        {
            GameObject x = Instantiate(xPrefab) as GameObject;
            x.transform.position = new Vector3(-4.1f, -3.3f, 0);
        }
        if (HongShotDirector.instance.price == 1000)
        {
            GameObject hun = Instantiate(hundredPrefab) as GameObject;
            hun.transform.position = new Vector3(-2.8f, -3.3f, 0);
        }
        else
        {
            GameObject x = Instantiate(xPrefab) as GameObject;
            x.transform.position = new Vector3(-2.8f, -3.3f, 0);
        }
        if (HongToppingDirector.instance.price == 1000)
        {
            GameObject hun = Instantiate(hundredPrefab) as GameObject;
            hun.transform.position = new Vector3(-1.4f, -3.3f, 0);
        }
        else
        {
            GameObject x = Instantiate(xPrefab) as GameObject;
            x.transform.position = new Vector3(-1.4f, -3.3f, 0);
        }
        if (HongCreamDirector.instance.price == 1000)
        {
            GameObject hun = Instantiate(hundredPrefab) as GameObject;
            hun.transform.position = new Vector3(0.0f, -3.3f, 0);
        }
        else
        {
            GameObject x = Instantiate(xPrefab) as GameObject;
            x.transform.position = new Vector3(0.0f, -3.3f, 0);
        }
        if (KimCupSizeDirector.instance.price == 1000)
        {
            GameObject hun = Instantiate(hundredPrefab) as GameObject;
            hun.transform.position = new Vector3(-7.0f, -4.4f, 0);
        }
        else
        {
            GameObject x = Instantiate(xPrefab) as GameObject;
            x.transform.position = new Vector3(-7.0f, -4.4f, 0);
        }
        if (KimLiquidDirector.instance.price == 1000)
        {
            GameObject hun = Instantiate(hundredPrefab) as GameObject;
            hun.transform.position = new Vector3(-5.5f, -4.4f, 0);
        }
        else
        {
            GameObject x = Instantiate(xPrefab) as GameObject;
            x.transform.position = new Vector3(-5.5f, -4.4f, 0);
        }
        if (KimSyrupDirector.instance.price == 1000)
        {
            GameObject hun = Instantiate(hundredPrefab) as GameObject;
            hun.transform.position = new Vector3(-4.1f, -4.4f, 0);
        }
        else
        {
            GameObject x = Instantiate(xPrefab) as GameObject;
            x.transform.position = new Vector3(-4.1f, -4.4f, 0);
        }
        if (KimShotDirector.instance.price == 1000)
        {
            GameObject hun = Instantiate(hundredPrefab) as GameObject;
            hun.transform.position = new Vector3(-2.8f, -4.4f, 0);
        }
        else
        {
            GameObject x = Instantiate(xPrefab) as GameObject;
            x.transform.position = new Vector3(-2.8f, -4.4f, 0);
        }
        if (KimToppingDirector.instance.price == 1000)
        {
            GameObject hun = Instantiate(hundredPrefab) as GameObject;
            hun.transform.position = new Vector3(-1.4f, -4.4f, 0);
        }
        else
        {
            GameObject x = Instantiate(xPrefab) as GameObject;
            x.transform.position = new Vector3(-1.4f, -4.4f, 0);
        }
        if (KimCreamDirector.instance.price == 1000)
        {
            GameObject hun = Instantiate(hundredPrefab) as GameObject;
            hun.transform.position = new Vector3(0.0f, -4.4f, 0);
        }
        else
        {
            GameObject x = Instantiate(xPrefab) as GameObject;
            x.transform.position = new Vector3(0.0f, -4.4f, 0);
        }
    }
}
