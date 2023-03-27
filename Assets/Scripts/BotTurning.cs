using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotTurning : MonoBehaviour
{
    private Animator _animator;

    private float blend;
    // Start is called before the first frame update
    void Start()
    {
        _animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)){
            _animator.SetTrigger("a");
            
            blend = 0;
        }

        if (blend < 1)
        {
            blend += Time.deltaTime;
        }
        _animator.SetFloat("Blend", blend);
    }
}
