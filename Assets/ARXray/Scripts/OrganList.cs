using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrganList : MonoBehaviour
{
    public Image brainIcon;

    public void OnBrainFound()
    {
        brainIcon.color = Color.white;
    }
}
