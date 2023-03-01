using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    public AudioSource player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
     void Update()
    {
         if (Input.GetKey(KeyCode.Space)) {
            player.Stop();
        }

        else if(Input.GetKey(KeyCode.P)) {
            player.Play();
        }

    }
    public void playSound()
    {
        player.Play();
    }
}
