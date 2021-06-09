using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stepsSounds : MonoBehaviour
{
    CharacterController cc;
    private AudioSource walkingSounds;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
        walkingSounds = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(cc.isGrounded == true && cc.velocity.magnitude > 2f)
        {
            walkingSounds.Play();
        }
    }
}
