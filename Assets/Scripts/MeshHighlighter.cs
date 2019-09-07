using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class MeshHighlighter : MonoBehaviour
{
    private MeshRenderer originalMesh;
    [SerializeField]
    private MeshRenderer highlightedMesh;
    
    // Start is called before the first frame update
    void Start()
    {
        originalMesh = GetComponent<MeshRenderer>(); 
    }

    public void EnableHighlight(bool onOff)
    {
        if(highlightedMesh != null)
        {
            highlightedMesh.enabled = onOff;
            originalMesh.enabled = !onOff;
        }
    }

    /// <summary>
    /// Called when the mouse enters the GUIElement or Collider.
    /// </summary>
    void OnMouseEnter()
    {
        EnableHighlight(true);
    }

    /// <summary>
    /// Called when the mouse is not any longer over the GUIElement or Collider.
    /// </summary>
    void OnMouseExit()
    {
        EnableHighlight(false);
    }
}
