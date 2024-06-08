using UnityEngine;
using TMPro;

public class NPCTalking : MonoBehaviour
{
    public TextMeshPro npcNameText; // Assign a TMP Text element in the inspector
    public TextMeshPro dayText; // Assign a TMP Text element in the inspector

    void Start()
    {
        if (npcNameText != null)
        {
            dayText.text = "Talking to: " + SceneData.NPCName;
            npcNameText.text = "Day #" + SceneData.Day;

        }
    }
}
