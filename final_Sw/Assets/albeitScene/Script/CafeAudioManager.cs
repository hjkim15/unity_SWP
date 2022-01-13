using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CafeAudioManager : MonoBehaviour
{
    public static CafeAudioManager instance = null;

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
