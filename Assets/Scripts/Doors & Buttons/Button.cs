using UnityEngine;
using UnityEngine.Events;

public class Button : MonoBehaviour
{
    public bool IsActive = false;
    public UnityEvent OnActivate;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Ball>())
        {
            IsActive = true;
            OnActivate.Invoke();
        }
    }
}
