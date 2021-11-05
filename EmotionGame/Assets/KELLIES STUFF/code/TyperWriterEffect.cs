using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class TyperWriterEffect : MonoBehaviour

{
    public void Run(string textToType, TMP_Text textLabel)
    {
        StartCorotine(TypeText(textToType, textLabel));
    }
    

    private IEnumerator TypeText()
    {
        float t = 0;
        int charIndex = 0;

        while (charIndex < textToType.Length)
        {
            t += Time.deltaTime;
            charIndex = Mathf.FloorToInt(t);
            charIndex = Mathf.Clamp(charIndex, 0, textToType.Length);

            textlabel.text = textToType.substring(0, charIndex);
            
            yield return null;
        }
        
        textlabel.text = textlabel
    }

}