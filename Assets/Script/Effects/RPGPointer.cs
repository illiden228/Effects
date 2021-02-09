using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGPointer : MonoBehaviour
{
    [SerializeField] private GameObject _pointerPrefab;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            var ray = Camera.main.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));

            if (Physics.Raycast(ray, out hit))
                Instantiate(_pointerPrefab, new Vector3(hit.point.x, hit.point.y + 0.1f, hit.point.z), Quaternion.identity);
        }
    }
}
