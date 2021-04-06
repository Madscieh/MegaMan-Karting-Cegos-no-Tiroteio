using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCapacete : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject player1;
        private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Tocou");
        if (other.CompareTag("Player"))
        {
            player.GetComponent<KartControl>().amno++;
            Destroy(gameObject, .2f);
        }
        if (other.CompareTag("Player2"))
        {
            player1.GetComponent<KartControlOne>().amnoOne++;
            Destroy(gameObject, .2f);
        }
    }
    /*
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Player2")
        {
            collision.gameObject.GetComponent<KartControl>().amno++;
            Destroy(gameObject, .01f);
        }
    }
    */
}