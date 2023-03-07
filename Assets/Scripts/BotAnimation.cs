using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotAnimation : MonoBehaviour
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
        if (Input.GetKey(KeyCode.LeftShift))
        {
            _animator.SetBool("run",true);
        }
        else
        {
            _animator.SetBool("run",false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _animator.SetBool("jump", true);
        }
        else
        {
            _animator.SetBool("jump", false);
        }

        if (Input.GetKey(KeyCode.W))
        {
            _animator.SetBool("walk",true);
        }
        else
        {
            _animator.SetBool("walk",false);
        }
    }
}
