using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    Vector3 mousePosition;

    private Vector3 getMousePos(){
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDown(){
        mousePosition = Input.mousePosition - getMousePos();
    }

    private void OnMouseDrag(){
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition);
    }
}
