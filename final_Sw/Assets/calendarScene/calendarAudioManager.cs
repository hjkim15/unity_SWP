using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calendarAudioManager : MonoBehaviour
{
    public static calendarAudioManager instance = null;

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

    }

    void Update()
    {

    }
}
