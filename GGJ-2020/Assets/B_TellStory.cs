using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class B_TellStory : MonoBehaviour
{
    [SerializeField] private Dialogue _dialogue;
    [SerializeField] private TextMeshProUGUI _myText;

    private int currentIndex = 0;

    public void StartDialogue()
    {
        currentIndex = 0;
        this.transform.GetChild(0).gameObject.SetActive(true);

        StartCoroutine(TellStory());
    }

    private IEnumerator TellStory()
    {
        _myText.text = _dialogue.sentences[currentIndex];

        yield return new WaitForSeconds(5);

        currentIndex++;

        if (currentIndex < _dialogue.sentences.Length)
            StartCoroutine(TellStory());
        else
            this.transform.GetChild(0).gameObject.SetActive(false);
    }
}
