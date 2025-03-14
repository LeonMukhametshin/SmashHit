using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEditor;
using UnityEngine;

public class CameraCollision : MonoBehaviour
{
    [SerializeField] private string[] dangerousTags;

   /* private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
*/
    
    private CamerMovement camerMovement;

    private void Awake()
    {
        camerMovement = GetComponent<CamerMovement>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        for (int i = 0; i < dangerousTags.Length; i++)
        {
            if(collision.gameObject.CompareTag(dangerousTags[i]))
            {
                GameManager.TakeDamage();
            }       
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Aceleration"))
        {
            camerMovement.IncreaseSpeed();
            Debug.Log("speed up");
        }
    }
}   