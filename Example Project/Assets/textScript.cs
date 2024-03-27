using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class textScript : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        TMP_Text myText = GetComponent<TMP_Text>();
        int linkIndex = TMP_TextUtilities.FindIntersectingLink(myText, eventData.position, null);
        if(linkIndex != -1)
        {
            TMP_LinkInfo myLink = myText.textInfo.linkInfo[linkIndex];
            Application.OpenURL(myLink.GetLinkID());
        }
    }
}



/*  
    /// <summary>
    /// Structure containing information about individual links contained in the text object.
    /// </summary>

    public struct TMP_LinkInfo
    {
        public TMP_Text textComponent;

        public int hashCode;

        public int linkIdFirstCharacterIndex;
        public int linkIdLength;
        public int linkTextfirstCharacterIndex;
        public int linkTextLength;

        internal char[] linkID;


        internal void SetLinkID(char[] text, int startIndex, int length)
        {
            if (linkID == null || linkID.Length < length) linkID = new char[length];

            for (int i = 0; i < length; i++)
                linkID[i] = text[startIndex + i];
        }




    /// <summary>
    /// Function which returns the text contained in a link.
    /// </summary>
    /// <param name="textInfo"></param>
    /// <returns></returns>

    public string GetLinkText()
    {
        string text = string.Empty;
        TMP_TextInfo textInfo = textComponent.textInfo;

        for (int i = linkTextfirstCharacterIndex; i < linkTextfirstCharacterIndex + linkTextLength; i++)
            text += textInfo.characterInfo[i].character;

        return text;
    }




    /// <summary>
    /// Function which returns the link ID as a string.
    /// </summary>
    /// <param name="text">The source input text.</param>
    /// <returns></returns>

    public string GetLinkID()
    {
        if (textComponent == null)
            return string.Empty;

        return new string(linkID, 0, linkIdLength);
        //return textComponent.text.Substring(linkIdFirstCharacterIndex, linkIdLength);

    }
}
*/
