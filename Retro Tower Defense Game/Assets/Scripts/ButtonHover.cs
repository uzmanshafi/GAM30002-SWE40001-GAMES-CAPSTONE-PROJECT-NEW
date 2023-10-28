using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class ButtonHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public TextMeshProUGUI popupText;
    public GameObject textBack;

    public void OnPointerEnter(PointerEventData eventData)
    {
        popupText.gameObject.SetActive(true);
        textBack.gameObject.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        popupText.gameObject.SetActive(false);
        textBack.gameObject.SetActive(false);
    }
}