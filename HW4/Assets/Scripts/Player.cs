using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour
{
    [SerializeField] private AudioSource _audio;
    [SerializeField] private Animator _animator;
    [SerializeField] private float _speed = 5f;
    private void Start()
    {
        _animator = GetComponent<Animator>();
        _audio = GetComponent<AudioSource>(); 
    }
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * 5f;

        transform.Translate(moveX, 0, moveZ);
    }
   
}
