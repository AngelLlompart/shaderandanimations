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

        if (Input.GetKeyDown(KeyCode.D))
        {
            _animator.SetTrigger("turnRight");
            //transform.rotation *= Quaternion.Euler(0,90,0);
            //StartCoroutine(DelayedRotation(90));
            /* Quaternion rotIni = transform.rotation;
            Quaternion rotY = transform.rotation;
            rotIni *= Quaternion.Euler(0,90,0);
            while (rotY.y < rotIni.y)
            {
                transform.Rotate(0,1,0);
                rotY = transform.rotation;
            }*/
        }
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            _animator.SetTrigger("turnLeft");
            //transform.rotation *= Quaternion.Euler(0,-90,0);
            //StartCoroutine(DelayedRotation(-90));
        }
    }

    private IEnumerator DelayedRotation(float y)
    {
        yield return new WaitForSecondsRealtime(0.2f);
        transform.rotation *= Quaternion.Euler(0,y,0);
    }
}
