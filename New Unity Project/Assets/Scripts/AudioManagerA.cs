using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerA : MonoBehaviour
{
    public AudioClip defaultAmbience;
    public AudioSource track01, track02;
    private bool isPlayingTrack01;

    public static AudioManagerA instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    private void Start()
    {
        track01 = gameObject.AddComponent<AudioSource>();//iceWorld
        track02 = gameObject.AddComponent<AudioSource>();
        isPlayingTrack01 = false;

        swapTrack(defaultAmbience);
    }

    // Update is called once per frame
    public void swapTrack(AudioClip newClip)
    {

        StopAllCoroutines();
        StartCoroutine(FadeTrack(newClip));
        isPlayingTrack01 = !isPlayingTrack01;
    }

    private IEnumerator FadeTrack(AudioClip newClip)
    {
        float timetoFade = 1.25f;
        float timeElapsed = 0;
        if (isPlayingTrack01)
        {
            track02.clip = newClip;
            track02.Play();
            while (timeElapsed < timetoFade)
            {
                //track02.volume = Mathf.Lerp(0, 1, timeElapsed / timetoFade);
                //track01.volume = Mathf.Lerp(0, 1, timeElapsed / timetoFade);
                track02.volume = 10;
                track01.volume = 0;
                timeElapsed = Time.deltaTime;
                yield return null;
            }
            track02.Stop();

        }
        else
        {
            //ReturnToDefault();
            track01.clip = newClip;
            track01.Play();
            while (timeElapsed < timetoFade)
            {
                //track02.volume = Mathf.Lerp(0, 1, timeElapsed / timetoFade);
                //track01.volume = Mathf.Lerp(0, 1, timeElapsed / timetoFade);
                track02.volume = 0;
                track01.volume = 10;
                timeElapsed = Time.deltaTime;
                yield return null;
            }
            track01.Stop();
        }
        isPlayingTrack01 = !isPlayingTrack01;
    }
    public void ReturnToDefault()
    {
        swapTrack(defaultAmbience);
    }
}
