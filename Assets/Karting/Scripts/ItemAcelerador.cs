using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAcelerador : MonoBehaviour
{
    [SerializeField]
    Rigidbody player;
    [SerializeField]
    Transform kart;
    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        audio.Play();
        player.AddForce(kart.forward * 1000);
        Destroy(gameObject, .2f);
    }
}
