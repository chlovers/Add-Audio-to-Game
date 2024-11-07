using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPlayAnimation : MonoBehaviour
{
    public GameObject AnimatedObject;

    private Animator _animator;

    private void Start()
    {
        _animator = AnimatedObject.GetComponent<Animator>();
        _animator.enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        _animator.enabled = true;
        _animator.SetBool("IsReversed", false);
        _animator.Play("recordplayer");
        
    }

    void OnTriggerExit(Collider other)
    {
        _animator.SetBool("IsReversed", true);
        _animator.Play("recordplayer");

       
    }

  
}
