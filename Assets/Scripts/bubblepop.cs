using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubblepop : MonoBehaviour
{
    public AudioSource sound;
    public GameObject bubble;
    
    // Start is called before the first frame update
    void Start()
    {
        sound.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerEnter(Collider other)
    {
        sound.Play();
        bubble.SetActive(false);
    }

     void OnTriggerExit(Collider other)
    {
        bubble.SetActive(true);
    }
}
