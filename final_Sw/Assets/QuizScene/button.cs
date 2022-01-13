using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void largeScale()
    {
        this.transform.localScale = new Vector3(1.3f, 1.3f, 1.3f);
    }

    public void reduction()
    {
        this.transform.localScale = new Vector3(1, 1, 1);
    }

    public void SceneChange()
    {

        if (PlayerPrefs.GetInt("retry") == 0)
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().saveCalDate(1);
            SceneManager.LoadScene("calendarScene");
        }
        else if (PlayerPrefs.GetInt("retry") == 1)
        {
            SceneManager.LoadScene("endScene");
        }
    }
}
