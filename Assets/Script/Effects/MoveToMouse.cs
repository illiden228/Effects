using UnityEngine;

[System.Serializable]

public class MoveToMouse : MonoBehaviour
{

    public float Speed = 8.0f;
    public float DistanceFromCamera = 5.0f;

    void Update()
    {
        Vector3 MousePosition = Input.mousePosition;
        MousePosition.z = DistanceFromCamera;

        Vector3 MouseScreenToWorld = Camera.main.ScreenToWorldPoint(MousePosition);

        Vector3 Position = Vector3.Lerp(transform.position, MouseScreenToWorld, 1.0f - Mathf.Exp(-Speed * Time.deltaTime));

        transform.position = Position;
    }
}