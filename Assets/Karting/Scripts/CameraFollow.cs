using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject target;
    public GameObject lookMe;
    public float velocity = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position,
            target.transform.position, Time.smoothDeltaTime*velocity);
        transform.LookAt(lookMe.transform);
    }
}
