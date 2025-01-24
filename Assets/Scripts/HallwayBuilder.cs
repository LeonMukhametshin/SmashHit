using UnityEngine;

public class HallwayBuilder : MonoBehaviour
{
    [SerializeField] private GameObject[] hallwayPrefabs;

    private GameObject previousHallway; 
    private GameObject currentHallway; 
    private GameObject lastHallway;

    private void Awake()
    {
        if(hallwayPrefabs != null) // != null - is not empty
        {
            int randomIndex = Random.Range(0, hallwayPrefabs.Length); 
            currentHallway = Instantiate(hallwayPrefabs[randomIndex], transform.position, Quaternion.identity);

            randomIndex = Random.Range(0, hallwayPrefabs.Length);
            lastHallway = Instantiate(hallwayPrefabs[randomIndex], currentHallway.GetComponent<Hallway>().ending.position, Quaternion.identity);
        }
    }
}