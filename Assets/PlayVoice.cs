using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayVoice : MonoBehaviour
{
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        string path = "voicelines/" + SceneData.NPCName + "-" + SceneData.Day;
        Debug.Log(path);
        AudioClip clip = Resources.Load<AudioClip>(path);
        if (clip != null)
        {
            audioSource.clip = clip;
            audioSource.Play();
        }
        else
        {
            Debug.LogError("Failed to load audio clip from path: " + path);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
