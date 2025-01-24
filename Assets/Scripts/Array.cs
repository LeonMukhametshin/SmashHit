using UnityEngine;

public class Array : MonoBehaviour
{
    [SerializeField] private string[] names = { "Ivan", "Leon", "Dima" }; // 0 ... n - 1, n - кол-во элементов

    private void Start()
    {
        int a = names.Length;
        while(a < 5)
        {
            print(a);
            a++;
        } 
    }
}
