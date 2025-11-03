using UnityEngine;

public class SpinVisual : MonoBehaviour
{
    [Tooltip("Axis to spin around (Y for a scary horizontal spin).")]
    public Vector3 axis = Vector3.up;

    [Tooltip("Degrees per second.")]
    public float speed = 180f;

    void Update()
    {
        transform.Rotate(axis, speed * Time.deltaTime, Space.Self);
    }
}