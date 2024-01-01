using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private AudioSource Player;
    private bool IsPlaying = false;

    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Barrier"))
        {
            if (IsPlaying == false)
            {
                IsPlaying = true;
                Player.Play();
            }
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Barrier"))
        {
            if (IsPlaying == true)
            {
                IsPlaying = false;
            }
        }
    }


}
