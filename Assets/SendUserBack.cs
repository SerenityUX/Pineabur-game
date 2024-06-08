using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SendUserBack : MonoBehaviour
{
    void Update()
    {
        // Check for the return key press to load the previous scene
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!string.IsNullOrEmpty(SceneData.PreviousScene))
            {
                StartCoroutine(LoadPreviousScene());
            }
        }
    }

    private IEnumerator LoadPreviousScene()
    {
        // Load the previous scene asynchronously
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(SceneData.PreviousScene);

        // Wait until the scene is fully loaded
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        // Restore player state after the scene is fully loaded
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            player.transform.position = SceneData.PlayerPosition;
            player.transform.rotation = SceneData.PlayerRotation;
        }
    }
}
