using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip playerHitSound, ReloadSound, targetDestorySound, shootingSound;
    static AudioSource audioSrc;
    void Start()
    {
        ReloadSound = Resources.Load<AudioClip>("9convert.com - Gun Reload Sound Effect Free Sound Effects");

        shootingSound = Resources.Load<AudioClip>("AutoGun_1p_01");

        targetDestorySound = Resources.Load<AudioClip>("9convert.com - Ram Bell Sound");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "reload":
                audioSrc.PlayOneShot(ReloadSound);
                break;

            case "shooting":
                audioSrc.PlayOneShot(shootingSound);
                break;

            case "targetDestory":
                audioSrc.PlayOneShot(targetDestorySound);
                break;
        }
    }
}
