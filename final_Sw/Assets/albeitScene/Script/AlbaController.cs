using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AlbaController : MonoBehaviour
{
    public AudioClip alba;
    public AudioClip doogu;
    AudioSource aud;
    bool bAudioPlay = false;
    bool bAudioPlay1 = false;

    float span1 = 8.0f;
    float span = 2.0f;
    float delta = 0;

    void Start()
    {
        this.aud = GetComponent<AudioSource>();
        Cafe2AudioManager.instance.AudioDestroy();
    }

    void Update()
    {
        this.delta += Time.deltaTime;

        if (bAudioPlay == false)
        {
            bAudioPlay = true;
            this.aud.PlayOneShot(this.alba);
        }

        if (this.delta > this.span)
        {
            if (bAudioPlay1 == false)
            {
                bAudioPlay1 = true;
                this.aud.PlayOneShot(this.doogu);
            }
        }

        if (this.delta > this.span1)
        {
            SceneManager.LoadScene("EndingScene");
        }
    }
}
