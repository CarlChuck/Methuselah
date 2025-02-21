using TMPro;
using UnityEngine;

[ExecuteInEditMode]
public class Attribute : MonoBehaviour
{
    [SerializeField] private string setAttributeName;
    [SerializeField] private string setAttributeValue;
    [SerializeField] private Color attributeColour;

    [SerializeField] private TextMeshProUGUI attributeName;
    [SerializeField] private TextMeshProUGUI attributeValue;

    private void Update()
    {
        attributeName.text = setAttributeName;
        attributeValue.text = setAttributeValue;
        attributeName.color = attributeColour;
        attributeValue.color = attributeColour;
    }

    public void UpdateAttributeValue(int newAttributeValue)
    {
        setAttributeValue = newAttributeValue.ToString();
    }
}
