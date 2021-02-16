using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle : MonoBehaviour
{

    private Camera toggle;
    // Start is called before the first frame update
    void Start()
    {
        toggle = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            toggle.enabled = !toggle.enabled;

        }
    }
}
