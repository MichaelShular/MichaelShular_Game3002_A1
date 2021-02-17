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
    public float Angle = 0f;
    public float Vel = 0f;
    public float points;

    // Start is called before the first frame update
    void Start()
    {
        ballRigidBody = GetComponent<Rigidbody>();
        debugline = new Vector3(0, 0, 0);
        points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.Space) && m_bIsGrounded)
        {
            shoot = false;
            OnKickBall();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            ballRigidBody.transform.position = new Vector3(0, 0, 20);
            ballRigidBody.velocity = Vector3.zero;
            ballRigidBody.angularVelocity = Vector3.zero;
        }
    }

    public void OnKickBall()
    {
        //xaxis is negative so its shoot in the direction of the slider
        InitialVelocity.z = Vel * Mathf.Cos(Angle * (3.14f / 180f)) * Mathf.Cos(-Xaxis * (3.14f / 180f));
        InitialVelocity.x = Vel * Mathf.Cos(Angle * (3.14f / 180f)) * Mathf.Sin(-Xaxis * (3.14f / 180f));
        InitialVelocity.y = Vel * Mathf.Sin(Angle * (3.14f / 180f));
        
        ballRigidBody.velocity = InitialVelocity; 
    }

    public void _XAxis(float a)
    {
      
        Xaxis = a;
    }

    public void _AngleAmount(float b)
    {
        
        Angle = b;
    }

    public void _PowerKick(float c)
    {
        
        Vel = c;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
      
        Gizmos.DrawLine(debugline, transform.position);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Goal"))
        {
            points += 1f;
        }
    }
}
