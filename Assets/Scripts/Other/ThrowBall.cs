using System;
using UnityEngine;
using UnityEngine.Events;

public class ThrowBall : MonoBehaviour
{
    [SerializeField] private UnityEvent OnThrow;
    [SerializeField] private UnityEvent OnEmpty;

    [SerializeField] private GameObject ballPrefab;
    [SerializeField, Range(1, 500)] private float throwForce = 50f;

    private Camera mainCamera;

    private void Awake()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0) && !GameManager.IsUIBlocking)
        {
            Throw();
        }
    }

    private void Throw()
    {
        if(GameManager.BallCount <= 0)
        {
            OnEmpty.Invoke();
            return;
        }

        Ray mouseRay = mainCamera.ScreenPointToRay(Input.mousePosition);
        Vector3 throwDirection = (mouseRay.GetPoint(1f) - transform.position).normalized;

        GameObject newBall = Instantiate(ballPrefab, transform.position, Quaternion.identity);

        if(newBall.GetComponent<Rigidbody>())
        {
            Rigidbody ballRB = newBall.GetComponent<Rigidbody>();
            ballRB.AddForce(throwDirection * throwForce, ForceMode.VelocityChange);
        }

        GameManager.BallCount--;
        OnThrow.Invoke();
    }
}
