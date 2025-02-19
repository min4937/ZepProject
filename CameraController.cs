using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;

    
    void FixedUpdate()
    {
        if (target == null)
            return;

        Vector3 pos = transform.position;
        pos.x = target.position.x;
        pos.y = target.position.y;
        transform.position = Vector3.Lerp(transform.position, pos, 0.2f);

    }

}
