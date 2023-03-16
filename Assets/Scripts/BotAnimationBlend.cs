using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotAnimationBlend : MonoBehaviour
{
    private Animator _animator;

    public float velocity = 0;

    public float acceleration = 0.1f;

    public float desacceleration = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        _animator = this.GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        bool move = Input.GetKey(KeyCode.W);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _animator.SetBool("jump", true);
        }
        else
        {
            _animator.SetBool("jump", false);
        }

        if (move && velocity < 1)
        {
            velocity += Time.deltaTime * acceleration;
        }
        if(!move && velocity > 0)
        {
            velocity -= Time.deltaTime * desacceleration;
        }

        _animator.SetFloat("Velocity", velocity);
        if (Input.GetKeyDown(KeyCode.D))
        {
            _animator.SetTrigger("turnRight");
            StartCoroutine(DelayedRotation(90));
            velocity = 0;
        }
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            _animator.SetTrigger("turnLeft");
            //transform.rotation *= Quaternion.Euler(0,-90,0);
            StartCoroutine(DelayedRotation(-90));
            velocity = 0;
        }
    }

    private IEnumerator DelayedRotation(float y)
    {
        yield return new WaitForSecondsRealtime(0.2f);
        transform.rotation *= Quaternion.Euler(0,y,0);
    }
}
