using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienAnimController : MonoBehaviour
{
    private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        _animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _animator.SetInteger("state",1);
        }
        else
        {
            _animator.SetInteger("state",0);
        }
    }
}
