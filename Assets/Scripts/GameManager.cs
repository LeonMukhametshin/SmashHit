using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    // new - выделение памяти 
    public static UnityEvent OnLoss = new UnityEvent();

    public static int BallCount;

    [SerializeField] private int initialBallCount = 25;

    private static int  maxBallCount = 50;

    private void Awake()
    {
        BallCount = initialBallCount;
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

    public static void Healing(int count = 25)
    {
         BallCount += count;

        if(BallCount > maxBallCount)
        {
            BallCount = maxBallCount;
        }
    }
}