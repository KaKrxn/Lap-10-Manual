using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Vector3 offset = new Vector3(0f,0f,-10f);
    float smoothTime = 0.25f;
    Vector3 velosity = Vector3.zero;

    [SerializeField] Transform target;

    private void Update()
    {
        Vector3 tragetPosiition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, tragetPosiition, ref velosity, smoothTime);
    }
}
