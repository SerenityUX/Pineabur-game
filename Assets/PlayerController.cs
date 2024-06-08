using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Speed of the player movement
    public float speed = 5.0f;

    // Audio sources for different movement directions
    public AudioSource forwardAudio;
    public AudioSource backwardAudio;
    public AudioSource verticalAudio;

    // Boolean to check if player is walking
    private bool isWalking = false;

    void Start()
    {
        // Check if there is a saved position and rotation in SceneData
        if (SceneData.PlayerPosition != Vector3.zero || SceneData.PlayerRotation != Quaternion.identity)
        {
            // Set the player's position and rotation to the saved values
            transform.position = SceneData.PlayerPosition;
            transform.rotation = SceneData.PlayerRotation;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Get the input from the vertical axis (W/S keys or Up/Down arrows)
        float move = Input.GetAxis("Vertical");

        // Check if the player is moving
        if (move != 0)
        {
            // Set walking animation boolean
            isWalking = true;

            // Check the direction of the movement and play corresponding audio
            if (move > 0)
            {
                PlayAudio(forwardAudio);
                // Rotate the player to face forward
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            else if (move < 0)
            {
                PlayAudio(backwardAudio);
                // Rotate the player to face backward
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }
        }
        else
        {
            isWalking = false;
            StopAllAudio();
        }

        // Move the player forward and backward along the Z-axis
        transform.Translate(0, 0, move * speed * Time.deltaTime);
        SavePlayerState();
    }

    void SavePlayerState()
    {
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            SceneData.PlayerPosition = player.transform.position;
            SceneData.PlayerRotation = player.transform.rotation;
        }
    }

    void PlayAudio(AudioSource audio)
    {
        if (!audio.isPlaying)
        {
            StopAllAudio();
            audio.Play();
        }
    }

    void StopAllAudio()
    {
        forwardAudio.Stop();
        backwardAudio.Stop();
        verticalAudio.Stop();
    }
}
