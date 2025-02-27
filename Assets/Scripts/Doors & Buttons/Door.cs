using UnityEngine;
using UnityEngine.Events;

public class Door : MonoBehaviour
{
    public UnityEvent OnOpen;

    [SerializeField] private Button[] buttons;

    private void Awake()
    {
        foreach (var button in buttons)
        {
            button.OnActivate.AddListener(CheckContact);
        }
    }

    private void CheckContact()
    {
        foreach (var button in buttons)
        {
            if(button.gameObject.activeSelf == true && button.IsActive == false)
            {
                return;
            }
        }

        OnOpen.Invoke();
    }
}
