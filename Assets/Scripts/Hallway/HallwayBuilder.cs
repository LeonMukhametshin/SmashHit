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
            currentHallway = RandomHallway(transform.position);

            lastHallway = RandomHallway(currentHallway.GetComponent<Hallway>().ending.position);
        }
    }

    public void BuildContinue()
    {
        if(previousHallway != null)
        {
            Destroy(previousHallway);
        }

        previousHallway = currentHallway;
        currentHallway = lastHallway;

        lastHallway = RandomHallway(currentHallway.GetComponent<Hallway>().ending.position);
    }

    private GameObject RandomHallway(Vector3 spawnPosition)
    {
        int randomIndex = Random.Range(0, hallwayPrefabs.Length);
        return Instantiate(hallwayPrefabs[randomIndex], spawnPosition, Quaternion.identity);
    }
}