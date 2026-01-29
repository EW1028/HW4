/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
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
    if (GameController.Instance == null)
    return;
    GameController.Instance.OnPlayerFlap += HandlePlayerFlap;
    GameController.Instance.OnPointScored += HandlePointScored;
    GameController.Instance.OnGameOver += HandlePlayerHit;
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
*/
