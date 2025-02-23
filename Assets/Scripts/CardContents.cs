using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class CardContents : MonoBehaviour
{
    public Image background;
    public TextMeshProUGUI cardname;
    public TextMeshProUGUI description;
    public Image image;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {    
        Transform CardBackground = transform.Find("CardBackground");
        Transform CardName = transform.Find("CardName");
        Transform CardImage = transform.Find("CardImage");
        Transform CardDescription = transform.Find("CardDescription");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
