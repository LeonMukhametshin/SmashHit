using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    // new - выделение памяти 
    public static UnityEvent OnLoss = new UnityEvent();

    public static int BallCount;

    [SerializeField] private int initialBallCount = 25;

    private void Awake()
    {
        BallCount = initialBallCount;

        TakeDamage();
        TakeDamage(5);
    }

    public static void TakeDamage(int damage = 10)
    {
        BallCount -= damage;    

        if(BallCount <= 0)
        {
            BallCount = 0;
            OnLoss.Invoke();
        }
    }
}