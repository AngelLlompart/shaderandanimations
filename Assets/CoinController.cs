using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    private Animator _animator;
    void Start()
    {
        _animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            //_animator.SetInteger("stateChange", 0);
            _animator.Play("CoinRotation");
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            //_animator.SetInteger("stateChange", 1);
            _animator.Play("CoinTranslation");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            //_animator.SetInteger("stateChange", 2);
            _animator.Play("CoinScale");
        }
    }
}
