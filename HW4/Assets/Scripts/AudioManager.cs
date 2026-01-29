using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
   [Header("Audio Clips")]
   public AudioClip flapSound;
   public AudioClip scoreSound;
   public AudioClip hitSound;

   private AudioSource audioSource;
   private void Awake()
   {
    audioSource = GetComponent<AudioSource>();
   }

   private void OnEnable()
   {
    Debug.Log("OnEnable Active");
    if (GameController.Instance == null)
    return;
    GameController.Instance.OnPlayerFlap += HandlePlayerFlap;
    GameController.Instance.OnPointScored += HandlePointScored;
    GameController.Instance.OnGameOver += HandlePlayerHit;
    Debug.Log("OnEnable works?");
   }

   private void OnDisable()
   {
    if (GameController.Instance == null)
    return;
    GameController.Instance.OnPlayerFlap -= HandlePlayerFlap;
    GameController.Instance.OnPointScored -= HandlePointScored;
    GameController.Instance.OnGameOver -= HandlePlayerHit;
   }

   void HandlePlayerFlap()
   {
    Debug.Log("handle player flap method");
    audioSource.PlayOneShot(flapSound);
   }
    void HandlePointScored()
    {
     audioSource.PlayOneShot(scoreSound);
    }
    void HandlePlayerHit()
    {
     audioSource.PlayOneShot(hitSound);
    }
}

