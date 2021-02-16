using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControls : MonoBehaviour
{
    private Canvas toggle;
    void Start()
    {
        toggle = GetComponent<Canvas>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            toggle.enabled = !toggle.enabled;

        }
    }
}
