using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ParentTextEditor : MonoBehaviour
{
    public string locationText;
    public string priceAndTypeText;
    public string serviceOptionsText;
    public string addressText;
    public string openingHoursText;

    private void Start()
    {
        Transform locationTextTransform = FindChildTransformRecursive(transform, "LocationText");
        Transform priceAndTypeTextTransform = FindChildTransformRecursive(transform, "PriceAndTypeText");
        Transform serviceOptionsTextTransform = FindChildTransformRecursive(transform, "ServiceOptionsText");
        Transform addressTextTransform = FindChildTransformRecursive(transform, "AddressText");
        Transform openingHoursTextTransform = FindChildTransformRecursive(transform, "OpeningHoursText");

        SetTextValue(locationTextTransform, locationText);
        SetTextValue(priceAndTypeTextTransform, priceAndTypeText);
        SetTextValue(serviceOptionsTextTransform, serviceOptionsText);
        SetTextValue(addressTextTransform, addressText);
        SetTextValue(openingHoursTextTransform, openingHoursText);
    }

    private void SetTextValue(Transform textTransform, string text)
    {
        if (textTransform != null)
        {
            TextMeshProUGUI textMeshPro = textTransform.GetComponent<TextMeshProUGUI>();

            if (textMeshPro != null)
            {
                textMeshPro.text = text;
                //Debug.Log("Set Text: " + text);
            }
            else
            {
                //Debug.Log(textTransform.name + " GameObject doesn't have TextMeshProUGUI component!");
            }
        }
        else
        {
            //Debug.Log("Text GameObject not found!");
        }
    }

    private Transform FindChildTransformRecursive(Transform parent, string childName)
    {
        Transform childTransform = parent.Find(childName);

        if (childTransform != null)
        {
            return childTransform;
        }

        for (int i = 0; i < parent.childCount; i++)
        {
            childTransform = FindChildTransformRecursive(parent.GetChild(i), childName);

            if (childTransform != null)
            {
                return childTransform;
            }
        }

        return null;
    }
}
