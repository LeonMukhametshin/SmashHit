using UnityEngine;
using UnityEngine.UI;

public class NumbersManager : MonoBehaviour
{
    [SerializeField] private Text text;

    private void Update()
    {
        text.text = GameManager.BallCount.ToString();
    } 
}
