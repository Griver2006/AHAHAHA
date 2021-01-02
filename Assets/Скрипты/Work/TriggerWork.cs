using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWork : MonoBehaviour
{
    public GameObject work;
    public GameObject sound;
    bool go;
    float time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(go == true)
        {
            time += Time.deltaTime;
        }

        if(time >= 3)
        {
            go = false;
            time = 0;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && go == false)
        {
            work.GetComponent<Animator>().SetTrigger("go");
            sound.GetComponent<AudioSource>().Play();
            go = true;
        }
    }
}
