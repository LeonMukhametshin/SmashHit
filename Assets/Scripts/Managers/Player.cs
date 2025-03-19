using UnityEngine;

public class Player : MonoBehaviour
{
    private Jump jump;

    private void Awake()
    {
        jump = GetComponent<Jump>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump.Jumping();
        }
    }
}
