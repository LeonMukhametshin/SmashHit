using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CameraCollision : MonoBehaviour
{
    [SerializeField] private string[] dangerousTags;
    
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
            
        }
    }
}   