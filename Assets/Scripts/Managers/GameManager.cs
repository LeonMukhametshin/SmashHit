using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    // new - ��������� ������ 
    public static UnityEvent OnLoss = new UnityEvent();
    public static int BallCount;
    private static int maxBallCount = 50;

    public static bool IsUIBlocking = false;

    [SerializeField] private int initialBallCount = 25;

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

    public static void Reloading(int count = 5)
    {
        BallCount += count;

        if(BallCount > maxBallCount)
        {
            BallCount = maxBallCount;
        }
    }
}