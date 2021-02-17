using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalieMovement : MonoBehaviour
{
    Rigidbody body;
    private Vector3 moveTo;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        moveTo = new Vector3(Random.Range(-8.0f, 6.0f), Random.Range(0.3f, 1.8f), Random.Range(41.0f, 48.0f));
        GameObject.Find("Loc").GetComponent<Transform>().position = moveTo;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }
    void OnCollisionStay(Collision collision)
    {
        Debug.Log("WPOW");
        moveTo = new Vector3(Random.Range(-8.0f, 6.0f), Random.Range(0.3f, 1.8f), Random.Range(41.0f, 48.0f));
        GameObject.Find("Loc").GetComponent<Transform>().position = moveTo;
    }
    void Move()
    {
        float step = Random.Range(1.0f, 10.0f) * Time.deltaTime;
        body.position = Vector3.MoveTowards(body.position, moveTo, step);
    }
 
}
