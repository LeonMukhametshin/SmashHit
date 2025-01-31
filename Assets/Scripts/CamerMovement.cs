using UnityEngine;

public class CamerMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    private float currentSpeed;

    private Vector3 rotateDirection;

    private void Start()
    {
        currentSpeed = speed;
    }
    private void FixedUpdate() // 0.02 - Time.fixedDeltaTime
    {
        Movement();

    }

    private void Movement()
    {
        currentSpeed = Mathf.Lerp(currentSpeed, speed, Time.fixedDeltaTime);
        transform.Rotate(rotateDirection);
        transform.position += transform.forward * currentSpeed * Time.fixedDeltaTime;

    }











}
