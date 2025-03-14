using UnityEngine;

public class CamerMovement : MonoBehaviour
{
    [SerializeField] private float initialSpeed;
     private float currentSpeed;
     private float maxSpeed = 30;


    private void OnEnable()
    {
        GameManager.OnLoss.AddListener(BreakMovement);
    }

    private void Start()
    {
        currentSpeed = initialSpeed;
    }

    private void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        currentSpeed = Mathf.Lerp(currentSpeed, initialSpeed, Time.fixedDeltaTime);
        transform.position += transform.forward * currentSpeed * Time.fixedDeltaTime;
    }

    private void BreakMovement()
    {
        initialSpeed = 0;
    }

    public void IncreaseSpeed(float additionalSpeed = 5)
    {
        currentSpeed += additionalSpeed;

        if(currentSpeed > maxSpeed)
        {
            currentSpeed = maxSpeed;
        }
    }
}