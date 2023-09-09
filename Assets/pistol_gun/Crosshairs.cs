using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using Microsoft.Unity.VisualStudio.Editor;

public class Crosshairs : MonoBehaviour
{
    public Image crosshairs;
    public Sprite normalSprite;
    public Sprite sniperSprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeToSniper(){
        this.GetComponent<UnityEngine.UI.Image>().sprite = sniperSprite;
        GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical,200);
        GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal,200);
    }
    public void ChangeToNormal(){
        this.GetComponent<UnityEngine.UI.Image>().sprite = normalSprite;
        GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical,100);
        GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal,100);
    }
}
