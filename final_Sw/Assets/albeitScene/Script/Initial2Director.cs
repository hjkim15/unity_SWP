using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Initial2Director : MonoBehaviour
{
    public static Initial2Director instance = null;

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
    public int totalpCount = 0;

    void Start()
    {
        CafeAudioManager.instance.AudioDestroy();

        int number = Random.Range(0, 3);

        if (number == 0)
            SceneManager.LoadScene("ByunScene");
        else if (number == 1)
            SceneManager.LoadScene("HongScene");
        else
            SceneManager.LoadScene("KimScene");
    }

    void Update()
    {

    }
}
