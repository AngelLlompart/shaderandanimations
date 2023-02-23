using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private Animator _animator;
    void Start()
    {
        _animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            _animator.SetInteger("stateChange", 0);
        }
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            _animator.SetInteger("stateChange", 1);
        }
    }
}
