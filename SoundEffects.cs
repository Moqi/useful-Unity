using UnityEngine;
using System.Collections;

public class SoundEffects : MonoBehaviour
{
    public AudioClip[] effects = new AudioClip[10];

    public enum Effect
    {
        AUDIO1,
        AUDIO2,
        AUDIO3,
        AUDIO4,
        AUDIO5,
        AUDIO6,
        AUDIO7,
        AUDIO8,
        AUDIO9,
        AUDIO10,
    }

    //singleton
    private static SoundEffects instance = null;
    public static SoundEffects Instance { get { return instance; } }

    void Awake()
    {
        instance = this;
        gameObject.AddComponent<AudioSource>();
    }

    public AudioClip Return(Effect effect)
    {
        switch (effect)
        {
            case Effect.AUDIO1:
                return effects[0];
            case Effect.AUDIO2:
                return effects[1];
            case Effect.AUDIO3:
                return effects[2];
            case Effect.AUDIO4:
                return effects[3];
            case Effect.AUDIO5:
                return effects[4];
            case Effect.AUDIO6:
                return effects[5];
            case Effect.AUDIO7:
                return effects[6];
            case Effect.AUDIO8:
                return effects[7];
            case Effect.AUDIO9:
                return effects[6];
            case Effect.AUDIO10:
                return effects[7];
        }
        return null;
    }

    public void Play(Effect effect)
    {
        switch (effect)
        {
            case Effect.AUDIO1:
                audio.PlayOneShot(effects[0]);
                break;
            case Effect.AUDIO2:
                audio.PlayOneShot(effects[1]);
                break;
            case Effect.AUDIO3:
                audio.PlayOneShot(effects[2]);
                break;
            case Effect.AUDIO4:
                audio.PlayOneShot(effects[3]);
                break;
            case Effect.AUDIO5:
                audio.PlayOneShot(effects[4]);
                break;
            case Effect.AUDIO6:
                audio.PlayOneShot(effects[5]);
                break;
            case Effect.AUDIO7:
                audio.PlayOneShot(effects[6]);
                break;
            case Effect.AUDIO8:
                audio.PlayOneShot(effects[7]);
                break;
            case Effect.AUDIO9:
                audio.PlayOneShot(effects[8]);
                break;
            case Effect.AUDIO10:
                audio.PlayOneShot(effects[9]);
                break;
        }
    }
}