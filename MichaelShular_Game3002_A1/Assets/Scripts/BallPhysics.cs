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
    public float Xaxis;
    public float Yaxis;
    public float Zaxis;
    public float Angle;
    public float Power;

    // Start is called before the first frame update
    void Start()
    {
        ballRigidBody = GetComponent<Rigidbody>();
        debugline = new Vector3(0, 0, 0);
        InitialVelocity.x = 0;
        InitialVelocity.y = 0;
        InitialVelocity.z = 0;
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



        InitialVelocity.x = Xaxis;
        InitialVelocity.y = Yaxis;
        InitialVelocity.z = Zaxis;
        ballRigidBody.velocity = InitialVelocity; 
    }

    public void X_Axis(int a)
    {
        Xaxis = a;
    }

    public void AngleAmount(int a)
    {
        Angle = a;
    }

    public void PowerKick(int a)
    {
        Power = a;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
      
        Gizmos.DrawLine(debugline, transform.position);
    }
}
