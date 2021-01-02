using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2KOT2 : MonoBehaviour
{
    public GameObject sound;

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
        if(other.gameObject.tag == "Player")
        {
            sound.GetComponent<AudioSource>().Play();
            Destroy(gameObject);
        }
    }
}
