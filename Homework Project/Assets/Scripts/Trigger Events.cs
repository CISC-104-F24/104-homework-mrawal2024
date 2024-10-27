using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvents : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered zone.");
        }

        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false); // Hides the platform
            Debug.Log("Platform hidden.");
        }

        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            Debug.Log("Collectible destroyed.");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime);

                }

    }

    private void OnTriggerExit(Collider other)
    {

    }

}
