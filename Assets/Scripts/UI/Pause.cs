using UnityEngine;
using UnityEngine.Events;

public class Pause : MonoBehaviour
{
    [SerializeField] private UnityEvent onPauseEnable;
    [SerializeField] private UnityEvent onPauseDisable;

    private bool isActive = false;

    public void PauseOn()
    {
        isActive = true;
        Time.timeScale = 0f;
        onPauseEnable.Invoke();
    }

    public void PauseOff()
    {
        isActive = false;
        Time.timeScale = 1f;
        onPauseDisable.Invoke();
    }
}
