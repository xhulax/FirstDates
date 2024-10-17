using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public Dialogue dialogue2;
    public Dialogue dialogue3;


    public void TriggerDialogue()
    {
        switch (GameManager.Instance.gameLoop)
        {
            case 0:
                FindObjectOfType<DiaryText>().StartText(dialogue);
                break;
            case 1:
                FindObjectOfType<DiaryText>().StartText(dialogue2);
                break;
            case 2:
                FindObjectOfType<DiaryText>().StartText(dialogue3);
                break;

        }
    }
}
