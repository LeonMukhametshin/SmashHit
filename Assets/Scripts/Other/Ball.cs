using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float timeToDestroy = 5;

    private void Start()
    {
        Destroy(gameObject, timeToDestroy);
    }
}
