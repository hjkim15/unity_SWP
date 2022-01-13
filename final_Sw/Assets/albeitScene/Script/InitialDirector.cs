using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitialDirector : MonoBehaviour
{
    public static InitialDirector instance = null;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            if (instance != this)
                Destroy(this.gameObject);
        }
    }
    public int totalsCount = 0;

    void Start()
    {
        int number = Random.Range(0, 4);

        if (number == 0)
            SceneManager.LoadScene("DoYeonScene");
        else if (number == 1)
            SceneManager.LoadScene("HeeJoScene");
        else if (number == 2)
            SceneManager.LoadScene("JiHyeScene");
        else
            SceneManager.LoadScene("MoonJungScene");

    }

    void Update()
    {

    }
}
