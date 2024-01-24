using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class MovingPlatform2D : MonoBehaviour
{
    public Transform platform;
    public Transform startpoint;
    public Transform endpoint;
    public float speed = 1.5f;
    int direction = 1;
    // Start is called before the first frame update
    private void Start()
    {
        Vector2 target = currentMovementTarget();

        platform.position = Vector2.Lerp(platform.position, target, speed * Time.deltaTime);
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
    Vector2 currentMovementTarget()
    {
        if (direction == 1)
        {
            return startpoint.position;
        }
        else
        {
            return endpoint.position;
        }
    }

    private void OnDrawGizmos()
    {
        if(platform != null && startpoint!= null && endpoint != null)
        {
            Gizmos.DrawLine(platform.transform.position, startpoint.position);
            Gizmos.DrawLine(platform.transform.position, endpoint.position);
        }
    }
}
