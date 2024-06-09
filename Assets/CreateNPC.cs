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
            // Determine the position, rotation, and scale
            Vector3 position;
            if (npcName == "aadhya")
            {
                position = new Vector3(-7.46f, 3.58f, -4.7297f);
            }
            else
            {
                position = new Vector3(-2.36f, 3.58f, -4.7297f);
            }
            Quaternion rotation = Quaternion.Euler(0, -180, 0);
            Vector3 scale = new Vector3(6.358303f, 6.358303f, 6.358303f);

            // Instantiate the prefab
            GameObject npcInstance = Instantiate(npcPrefab, position, rotation);

            // Apply the scale
            npcInstance.transform.localScale = scale;

            // Load the AnimatorController from the Resources folder
            RuntimeAnimatorController animatorController = Resources.Load<RuntimeAnimatorController>(npcName);

            if (animatorController != null)
            {
                // Add the Animator component to the instantiated prefab
                Animator npcAnimator = npcInstance.AddComponent<Animator>();
                npcAnimator.runtimeAnimatorController = animatorController;
            }
            else
            {
                Debug.LogError("AnimatorController not found in Resources: " + npcName);
            }
        }
        else
        {
            Debug.LogError("Prefab not found in Resources: " + npcName);
        }
    }
}
