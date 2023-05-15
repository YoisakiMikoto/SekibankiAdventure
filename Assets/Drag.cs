using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    private Vector3 beginPos;
    private void OnMouseDrag()
    {
        Vector2 startPoint = Input.mousePosition;
        Vector2 objectPosition = Camera.main.ScreenToWorldPoint(startPoint);
        transform.position = objectPosition;
    }
}
