using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UnityStandardAssets.Utility
{
    [RequireComponent(typeof(Text))]
    public class PointsUpdate : MonoBehaviour
    {
        private Text m_text;
        private float a;
        // Start is called before the first frame update
        void Start()
        {
            a = GameObject.Find("Ball").GetComponent<BallPhysics>().points;
            m_text = GetComponent<Text>();
        }

        // Update is called once per frame
        void Update()
        {
            a = GameObject.Find("Ball").GetComponent<BallPhysics>().points;
            m_text.text = string.Format("Points {0}", a);
        }
    }
}
