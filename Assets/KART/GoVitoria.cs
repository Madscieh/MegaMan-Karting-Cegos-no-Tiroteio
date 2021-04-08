using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GoVitoria : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {   
    
    }
     

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") )
        {
            SceneManager.LoadScene("WinPlayer1");
        }
        else if (other.CompareTag("Player2"))
        {
            
            SceneManager.LoadScene("WinPlayer2");
        }

       

    }
}
