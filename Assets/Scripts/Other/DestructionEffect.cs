using UnityEngine;

public class DestructionEffect : MonoBehaviour
{
    [SerializeField] private GameObject[] fragments;

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
            gameObject.SetActive(false);
        }
    }
}
