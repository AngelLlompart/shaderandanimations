using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotHumanoidAnimator : MonoBehaviour
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
        if (Input.GetKey(KeyCode.F))
        {
            _animator.SetBool("shooting", true);
        }
        else
        {
            _animator.SetBool("shooting", false);
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


        if (Input.GetKeyDown(KeyCode.G))
        {
            _animator.SetLayerWeight(1, 1);
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            
            _animator.SetLayerWeight(1, 0);
        }
    }
}
