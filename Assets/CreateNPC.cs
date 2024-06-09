using UnityEngine;

public class InstantiateNPC : MonoBehaviour
{
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
            Quaternion rotation;
            Vector3 scale;

            if (npcName == "franklin")
            {
                // Set transform properties for Franklin
                position = new Vector3(-2.51f, 4.06f, 22.09f);
                rotation = Quaternion.Euler(0, 355.378f, 0);
                scale = new Vector3(6.3583f, 6.3583f, 6.3583f);
            }
            else if (npcName == "emma")
            {
                // Set transform properties for Emma
                position = new Vector3(-21.3f, 3.7f, -4.7f);
                rotation = Quaternion.Euler(0, 180, 0);
                scale = new Vector3(6.3583f, 6.3583f, 6.3583f);
            }
            else if (npcName == "scarlett")
            {
                // Set transform properties for Scarlett
                position = new Vector3(-35.2f, 3.58f, -4.7f);
                rotation = Quaternion.Euler(0, 180, 0);
                scale = new Vector3(6.3583f, 6.3583f, 6.3583f);
            }
            else if (npcName == "dom")
            {
                // Set transform properties for Dom
                position = new Vector3(14.01f, 2.97f, -15.78f);
                rotation = new Quaternion(0, 1.0f, 0, 0);
                scale = new Vector3(5.0f, 5.0f, 5.0f);
            }
            else if (npcName == "tyler")
            {
                // Set transform properties for Tyler
                position = new Vector3(-9.23f, 5.04f, 21.99f);
                rotation = Quaternion.Euler(0, 0, 0);
                scale = new Vector3(6.3583f, 6.3583f, 6.3583f);
            }
            else if (npcName == "dylan")
            {
                // Set transform properties for Dylan
                position = new Vector3(-1.1f, 3.58f, 22.4f);
                rotation = Quaternion.Euler(0, 0, 0);
                scale = new Vector3(6.3583f, 6.3583f, 6.3583f);
            }
            else if (npcName == "sabrina")
            {
                // Set transform properties for Sabrina
                position = new Vector3(-2.4f, 3.58f, 22.7f);
                rotation = new Quaternion(0, -0.02253276f, 0, 0.99974614f);
                scale = new Vector3(6.3583f, 6.3583f, 6.3583f);
            }
            else if (npcName == "steve")
            {
                // Set transform properties for Steve
                position = new Vector3(-1.2f, 3.58f, 22.4f);
                rotation = new Quaternion(0, 0, 0, -1.0f);
                scale = new Vector3(6.3583f, 6.3583f, 6.3583f);
            }
            else if (npcName == "jane")
            {
                // Set transform properties for Jane
                position = new Vector3(-1.2f, 3.58f, 22.1f);
                rotation = new Quaternion(0, 0, 0, -1.0f);
                scale = new Vector3(6.3583f, 6.3583f, 6.3583f);
            }
            else if (npcName == "aadhya")
            {
                position = new Vector3(-7.46f, 3.58f, -4.7297f);
                rotation = Quaternion.Euler(0, -180, 0);
                scale = new Vector3(6.3583f, 6.3583f, 6.3583f);
            }
            else
            {
                position = new Vector3(-2.36f, 3.58f, -4.7297f);
                rotation = Quaternion.Euler(0, -180, 0);
                scale = new Vector3(6.3583f, 6.3583f, 6.3583f);
            }

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
