using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UnityStandardAssets.Utility
{
    [RequireComponent(typeof(Text))]
    public class YZAxisUpdate : MonoBehaviour
    {
        private Text m_text;
        private float a;
        // Start is called before the first frame update
        void Start()
        {
            a = GameObject.Find("Ball").GetComponent<BallPhysics>().Angle;
            m_text = GetComponent<Text>();
        }

        // Update is called once per frame
        void Update()
        {
            a = GameObject.Find("Ball").GetComponent<BallPhysics>().Angle;
            m_text.text = string.Format("YZ-axis angle {0}", a);
        }
    }
}