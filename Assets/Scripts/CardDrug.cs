using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragUIFixed : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    private bool isPicked = false; 
    public float moveSpeed = 10f;
    public Outline frame;
    void Start()
    {
        frame = GetComponentInChildren<Outline>();
        if (frame != null)
        {
            frame.enabled = false;
        }
    }
    void Update()
    {
        if (isPicked)
        {
            Vector3 mousePosition = Input.mousePosition;
            // turn to world postion
            mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, 10f));
            transform.position = Vector3.Lerp(transform.position, mousePosition, moveSpeed * Time.deltaTime);
        }
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        isPicked = !isPicked;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        frame.enabled = true;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        frame.enabled = false;
    }
}
