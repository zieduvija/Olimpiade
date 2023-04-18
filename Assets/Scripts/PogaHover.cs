using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PogaHover : MonoBehaviour
{
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    public void mainit()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }

    public void atgriezt()
    {
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }
}
