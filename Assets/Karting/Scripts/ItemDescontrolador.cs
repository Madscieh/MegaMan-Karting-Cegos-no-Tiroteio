using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDescontrolador : MonoBehaviour
{
    [SerializeField]
    Rigidbody player;
    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        audio.Play();
        player.AddTorque(new Vector3(200, 0, 0));
        Destroy(gameObject, .2f);
    }
}
