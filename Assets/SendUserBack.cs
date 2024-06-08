using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SendUserBack : MonoBehaviour
{
    private static Vector3 playerPosition;
    private static Quaternion playerRotation;
    private static string previousScene;
    private GameObject player;

    void Start()
    {
        player = GameObject.FindWithTag("Player"); // Assume the player object has a tag "Player"
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (!string.IsNullOrEmpty(previousScene))
            {
                StartCoroutine(LoadPreviousScene());
            }
        }
    }

    public static void SavePlayerState(GameObject player)
    {
        playerPosition = player.transform.position;
        playerRotation = player.transform.rotation;
        previousScene = SceneManager.GetActiveScene().name;
    }

    public static void LoadPlayerState(GameObject player)
    {
        player.transform.position = playerPosition;
        player.transform.rotation = playerRotation;
    }

    private IEnumerator LoadPreviousScene()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(previousScene);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            LoadPlayerState(player);
        }
    }
}
