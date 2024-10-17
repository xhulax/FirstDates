using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DiaryText : MonoBehaviour
{
    public TextMeshProUGUI diaryText;

    private Queue<string> Sentences;

    // Start is called before the first frame update
    void Start()
    {
        Sentences = new Queue<string>();
    }

   public void StartText (Dialogue dialogue)
    {

        Sentences.Clear();
        foreach (string sentence in dialogue.sentences)
        {
            Sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(Sentences.Count == 0)
        {
            Debug.Log((Sentences.Count).ToString());
            endDialogue();
            return;
        }

       string sentence = Sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        diaryText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            diaryText.text += letter;
            yield return null;
        }
    }

    public void endDialogue()
    {
        if (GameManager.Instance.gameLoop != 2)
        {
            GameManager.Instance.gameLoop += 1;
            LevelManager.Instance.LoadLevel("WakeUp!");
        }
        else
        {
            LevelManager.Instance.DateSuccess();
        }

    }

}
