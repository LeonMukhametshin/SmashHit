using UnityEngine;
using UnityEngine.EventSystems;

public class InputHandler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        GameManager.IsUIBlocking = true;
        Debug.Log(GameManager.IsUIBlocking);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        GameManager.IsUIBlocking = false;
        Debug.Log(GameManager.IsUIBlocking);
    }
}
