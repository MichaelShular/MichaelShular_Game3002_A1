using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UnityStandardAssets.Utility
{
    [RequireComponent(typeof(Text))]


    public class UIStats : MonoBehaviour
    {

        private Canvas toggle;


        void Start()
        {
            toggle = GetComponent<Canvas>();

        }
        void Update()
        {

            if (Input.GetKeyDown(KeyCode.S))
            {
                toggle.enabled = !toggle.enabled;
            }

        }
    }
}

