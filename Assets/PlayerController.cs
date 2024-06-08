using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    // Speed of the player movement
    public float speed = 5.0f;



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
}
