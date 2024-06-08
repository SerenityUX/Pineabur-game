using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class NPCTalking : MonoBehaviour
{
    public TextMeshPro npcNameText; // Assign a TMP Text element in the inspector
    public TextMeshPro dayText; // Assign a TMP Text element in the inspector
    public TextMeshPro npcTalkLine; // Assign a TMP Text element in the inspector

    private string npcVoiceLine;

    void Start()
    {
        if (npcNameText != null && dayText != null && npcTalkLine != null)
        {
            dayText.text = "Day #" + SceneData.Day;
            npcNameText.text = "Talking to: " + SceneData.NPCName;
            npcVoiceLine = GetNPCVoiceLine(SceneData.NPCName, SceneData.Day);

            if (!string.IsNullOrEmpty(npcVoiceLine))
            {
                npcTalkLine.text = npcVoiceLine;
            }
            else
            {
                npcTalkLine.text = "No voice lines available for today.";
            }
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            StartCoroutine(ReturnToPreviousScene());
        }
    }

    private string GetNPCVoiceLine(string npcId, int day)
    {
        foreach (var npc in NPCData.NPCList)
        {
            if (npc.Id == npcId)
            {
                if (day < npc.VoiceLines.Count)
                {
                    return npc.VoiceLines[day];
                }
            }
        }
        return null;
    }

    private IEnumerator ReturnToPreviousScene()
    {
        if (!string.IsNullOrEmpty(SceneData.PreviousScene))
        {
            AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(SceneData.PreviousScene);

            while (!asyncLoad.isDone)
            {
                yield return null;
            }

            GameObject player = GameObject.FindWithTag("Player");
            if (player != null)
            {
                player.transform.position = SceneData.PlayerPosition;
                player.transform.rotation = SceneData.PlayerRotation;
            }
        }
    }
}
