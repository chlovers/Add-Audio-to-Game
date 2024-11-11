using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAudio : MonoBehaviour
{
    public AudioSource Music;
  

    void OnTriggerEnter(Collider other)
    {
        Music.Pause();
    }

   void OnTriggerExit(Collider other)
    {

        StartCoroutine(Delay());

    }

 IEnumerator Delay()
    {
        
        yield return new WaitForSeconds(2);
        Music.UnPause();
    }
}
