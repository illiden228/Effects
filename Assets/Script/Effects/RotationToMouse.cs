using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationToMouse : MonoBehaviour
{
    private void Update()
    {
        Vector3 mouse = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
        transform.LookAt(mouse);
    }
}
