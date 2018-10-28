using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class changeCursor : MonoBehaviour {

    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    void OnMouseEnter()
    {
        Cursor.visible = true;
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        Vector3 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        cursorPos.z = 0.0f;
        transform.position = cursorPos;
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }

    // Use this for initialization
    void Start ()
    {
        //cursorTexture = Texture2D.blackTexture;
	}
	
	// Update is called once per frame
	void Update ()
    {
        OnMouseEnter();
	}
}
