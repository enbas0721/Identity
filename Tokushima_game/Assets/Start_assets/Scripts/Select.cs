using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Select : MonoBehaviour
{
    [SerializeField]
    private int built_index;

    [SerializeField]
    private AudioClip start_sound;

    private AudioSource audiosource;

    private void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand"))
        {
            audiosource.PlayOneShot(start_sound);
            SceneManager.LoadScene(built_index);
        }
    }
}
