using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;

    public Vector3 offset = new Vector3(0, 2, -10);
    public float smoothTime = 0.25f;

    Vector3 currentVelocity;

    private void LateUpdate()
    {
        FollowCamera();
    }

    private void FollowCamera()
    {
        Vector3 DesiredPosition = Target.position + offset;
        Vector3 SmoothedPosition = Vector3.Lerp(transform.position, DesiredPosition, smoothTime);
        transform.position = SmoothedPosition;

    }
}
