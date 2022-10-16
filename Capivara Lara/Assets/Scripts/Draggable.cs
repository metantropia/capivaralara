 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    Vector3 mousePositionOffset;

    private Vector3 GetMouseWolrdPosition()
    {

        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDown()
    {
        mousePositionOffset = gameObject.transform.position - GetMouseWolrdPosition();
    }

    private void OnMouseDrag()
    {
        transform.position = GetMouseWolrdPosition() + mousePositionOffset;
    }
}
