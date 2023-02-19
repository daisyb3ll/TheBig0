using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class TitleScreenOptions : MonoBehaviour, IPointerExitHandler, IPointerEnterHandler
{
    private Button MenuButton;
    public Sprite HoverSprite;
    public Sprite DefaultSprite;
    public GameObject Button;

    void Start()
    {
        MenuButton = GetComponent<Button>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        MenuButton.image.sprite = HoverSprite;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        MenuButton.image.sprite = DefaultSprite;
    }

    public void Hide()
    {
        Button.SetActive(false);
    }

    public void Show()
    {
        Button.SetActive(true);
    }

}
