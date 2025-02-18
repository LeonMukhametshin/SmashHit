using UnityEngine;

public class DestructionEffect : MonoBehaviour
{
    [SerializeField] private GameObject[] fragments;
    [SerializeField] private int addedBalls = 5;

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Ball>())
        {
            if(fragments != null)
            {
                for(int i = 0; i < fragments.Length; i++)
                {
                    fragments[i].gameObject.SetActive(true);
                    fragments[i].GetComponent<MeshRenderer>().enabled = true;

                    if (fragments[i].GetComponent<Rigidbody>())
                    {
                        fragments[i].GetComponent<Rigidbody>().useGravity = true;
                        fragments[i].GetComponent<Rigidbody>().isKinematic = false;
                    }
                }
            }
            Debug.Log("До " + GameManager.BallCount);
            GameManager.Reloading(addedBalls);
            Debug.Log("После " + GameManager.BallCount);
            gameObject.SetActive(false);
        }
    }
}
