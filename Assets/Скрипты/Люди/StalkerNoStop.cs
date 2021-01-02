using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StalkerNoStop : MonoBehaviour
{
    public GameObject sound;
    float time;
    public float MaxTime;
    bool go;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(go == false)
        {
            time += Time.deltaTime;
        }
        if(time >= MaxTime)
        {
            go = true;
            time = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && go == true)
        {
            sound.GetComponent<AudioSource>().Play();
            go = false;
        }
    }
}
