using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cafe2AudioManager : MonoBehaviour
{
    public static Cafe2AudioManager instance = null;

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

    public void AudioDestroy()
    {
        Destroy(transform.gameObject);
    }

    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
    }


    void Update()
    {

    }
}
