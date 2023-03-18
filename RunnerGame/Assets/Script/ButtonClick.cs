using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Image = UnityEngine.UI.Image;

public class ButtonClick : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    Image buttonImage;

    public Sprite buttonDown;
    public Sprite buttonUp;

    public GameObject textMove;

    void Start() {
        buttonImage = GetComponent<Image>();
    }

    public void OnPointerDown(PointerEventData eventData) {
        buttonImage.sprite = buttonDown;
        textMove.gameObject.transform.localPosition = new Vector3Int(0, -12, 0);
    }
    public void OnPointerUp(PointerEventData eventData) {
        buttonImage.sprite = buttonUp;
        textMove.gameObject.transform.localPosition = new Vector3Int(0, 0, 0);
    }
}
