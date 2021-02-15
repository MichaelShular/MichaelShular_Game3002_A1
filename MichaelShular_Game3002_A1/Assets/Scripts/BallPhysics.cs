using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPhysics : MonoBehaviour
{
    public Vector3 InitialVelocity;
    private Vector3 debugline;
    private Rigidbody ballRigidBody = null;
    private bool m_bIsGrounded = true;
    public bool shoot = false;
    private float Xaxis;
    private float Yaxis;
    private float Zaxis;
    private float Angle = 0f;
    private float Power = 0f;

    // Start is called before the first frame update
    void Start()
    {
        ballRigidBody = GetComponent<Rigidbody>();
        debugline = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (shoot && m_bIsGrounded)
        {
            shoot = false;
            OnKickBall();
        }
    }

    public void OnKickBall()
    {

        Yaxis = Power * Mathf.Sin(Angle);
        Zaxis = Power * Mathf.Cos(Angle);
        Debug.Log(Xaxis);
        Debug.Log(Yaxis);
        Debug.Log(Zaxis);

        InitialVelocity.x = Xaxis;
        InitialVelocity.y = Yaxis;
        InitialVelocity.z = Zaxis;
        ballRigidBody.velocity = InitialVelocity; 
    }

    public void _XAxis(float a)
    {
        Debug.Log(a);
        Xaxis = a;
    }

    public void _AngleAmount(float b)
    {
        Debug.Log(b);
        Angle = b;
    }

    public void _PowerKick(float c)
    {
        Debug.Log(c);
        Power = c;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
      
        Gizmos.DrawLine(debugline, transform.position);
    }
}
