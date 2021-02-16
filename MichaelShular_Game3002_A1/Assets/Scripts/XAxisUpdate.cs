using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UnityStandardAssets.Utility
{
    [RequireComponent(typeof(Text))]
    public class XAxisUpdate : MonoBehaviour
    {
        private Text m_text;
        private float a;
        // Start is called before the first frame update
        void Start()
        {
            a = GameObject.Find("Ball").GetComponent<BallPhysics>().Xaxis;
            m_text = GetComponent<Text>();
        }

        // Update is called once per frame
        void Update()
        {
            a = GameObject.Find("Ball").GetComponent<BallPhysics>().Xaxis;
            m_text.text = string.Format("X-axis angle {0}", a);
        }
    }
}
