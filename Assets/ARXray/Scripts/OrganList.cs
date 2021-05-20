using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrganList : MonoBehaviour
{
    public Image brainIcon;
    public Image heartIcon;
    public Image rightKidneyIcon;
    public Image leftKidneyIcon;
    public Image stomachIcon;
    public Image rightLungIcon;
    public Image leftLungIcon;
    public Image bladderIcon;

    public void OnBrainFound()
    {
        brainIcon.color = Color.white;
    }

    public void OnHeartFound()
    {
        heartIcon.color = Color.white;
    }

    public void OnRightKidneyFound()
    {
        rightKidneyIcon.color = Color.white;
    }

    public void OnLeftKidneyFound()
    {
        leftKidneyIcon.color = Color.white;
    }

    public void OnStomachFound()
    {
        stomachIcon.color = Color.white;
    }

    public void OnRightLungFound()
    {
        rightLungIcon.color = Color.white;
    }

    public void OnLeftLungFound()
    {
        leftLungIcon.color = Color.white;
    }

    public void OnBladderFound()
    {
        bladderIcon.color = Color.white;
    }
}
