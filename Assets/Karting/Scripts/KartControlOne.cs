using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KartControlOne : MonoBehaviour
{
    public GameObject capacete;
    public Transform kart;
    private float shootVelocity = 8f;
    public int amnoOne = 0;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace) && amnoOne > 0)
        {
            GameObject go = Instantiate(capacete, kart.position + kart.forward * 2, kart.rotation);
            go.GetComponent<Rigidbody>().velocity = kart.forward * shootVelocity;
            go.GetComponent<Collider>().isTrigger = false;
            amnoOne--;
        }
    }
}
