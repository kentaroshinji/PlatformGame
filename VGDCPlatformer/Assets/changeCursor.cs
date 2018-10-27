using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeCursor : MonoBehaviour {

    private Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    void OnMouseEnter()
    {
        Cursor.visible = true;
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0.0f);
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }

    // Use this for initialization
    void Start ()
    {
        cursorTexture = Texture2D.blackTexture;
	}
	
	// Update is called once per frame
	void Update ()
    {
        OnMouseEnter();
	}
}
