using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.EventSystems;

public class DrawCard : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject prefab;
    public Transform cardParent;
    UnityEngine.UI.Image image;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        image = GetComponentInChildren<UnityEngine.UI.Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        image.color = new Color(0.5417f,0.5417f,0.5417f);
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        image.color = new Color(0.8188f,0.8188f,0.8188f);
        SpawnCard(prefab, cardParent);
    }
    void SpawnCard(GameObject prefab, Transform cardParent)
    {
        GameObject newCard = Instantiate(prefab, cardParent);
        newCard.transform.localScale = Vector3.one;
    }
}
