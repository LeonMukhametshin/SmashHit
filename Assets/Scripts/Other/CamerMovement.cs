using UnityEngine;

public class CamerMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    private float currentSpeed;

    private void OnEnable()
    {
        GameManager.OnLoss.AddListener(BreakMovement);
    }

    private void Start()
    {
        currentSpeed = speed;
    }

    private void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        currentSpeed = Mathf.Lerp(currentSpeed, speed, Time.fixedDeltaTime);
        transform.position += transform.forward * currentSpeed * Time.fixedDeltaTime;
    }

    private void BreakMovement()
    {
        speed = 0;
    }
}