using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeCursor : MonoBehaviour
{
    [SerializeField] Texture2D original;
    [SerializeField] Texture2D cursorChange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void change()
    {
       Cursor.SetCursor(cursorChange, Vector2.zero, CursorMode.ForceSoftware);
    }

    public void back()
    {
        Cursor.SetCursor(original, Vector2.zero, CursorMode.ForceSoftware);
    }
}
