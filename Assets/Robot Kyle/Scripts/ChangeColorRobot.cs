using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorRobot : MonoBehaviour
{
    private SkinnedMeshRenderer sMeshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        sMeshRenderer = GetComponent<SkinnedMeshRenderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Sun")
        {
            sMeshRenderer.material.color = Color.red;
        }
    }
}
