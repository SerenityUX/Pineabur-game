using UnityEngine;

public class InstantiateNPC : MonoBehaviour
{
    // Assuming SceneData.NPCName is a public static variable containing the name of the NPC.
    // If SceneData.NPCName is in another script, you need to ensure it is accessible here.
    // Example:
    // public static class SceneData {
    //     public static string NPCName = "YourNPCName";
    // }

    void Start()
    {
        // Retrieve the NPC name from SceneData
        string npcName = SceneData.NPCName;

        Debug.Log(npcName);

        // Load the prefab from the Resources folder
        GameObject npcPrefab = Resources.Load<GameObject>(npcName);

        if (npcPrefab != null)
        {
            // Define the position, rotation, and scale
            Vector3 position = new Vector3(-2.36f, 3.58f, -4.7297f);
            Quaternion rotation = Quaternion.Euler(0, -180, 0);
            Vector3 scale = new Vector3(6.358303f, 6.358303f, 6.358303f);

            // Instantiate the prefab
            GameObject npcInstance = Instantiate(npcPrefab, position, rotation);

            // Apply the scale
            npcInstance.transform.localScale = scale;
        }
        else
        {
            Debug.LogError("Prefab not found in Resources: " + npcName);
        }
    }
}
