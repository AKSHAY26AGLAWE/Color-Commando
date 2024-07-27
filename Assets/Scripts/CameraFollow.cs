using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // The target the camera will follow
    public Vector3 offset = new Vector3(0, 1, -3); // Adjusted offset to keep the gun in view
    public float followSpeed = 5f; // Speed at which the camera follows the target

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, followSpeed * Time.deltaTime);
            transform.position = smoothedPosition;
            transform.LookAt(target); // Make the camera look at the target
        }
    }
}
