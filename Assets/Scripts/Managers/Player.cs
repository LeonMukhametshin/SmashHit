using UnityEngine;

public class Player : MonoBehaviour
{
    private Jump jump;
   
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump.jump();
        }
    }
}
