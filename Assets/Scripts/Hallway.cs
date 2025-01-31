using UnityEngine;

public class Hallway : MonoBehaviour
{
    [SerializeField] public Transform ending;

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Camera>())
        {
            FindObjectOfType<HallwayBuilder>().BuildContinue();
        }
    }
}