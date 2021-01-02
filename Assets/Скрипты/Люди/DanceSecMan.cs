using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceSecMan : MonoBehaviour
{
    public GameObject man;
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
            man.GetComponent<Animator>().SetTrigger("go");
            sound.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            man.GetComponent<Animator>().SetTrigger("no");
            sound.SetActive(false);
        }
    }
}
