using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeOutline : MonoBehaviour
{
    private void Awake()
    {
        var outline = this.gameObject.AddComponent<Outline>();
        outline.enabled = true;
        outline.OutlineColor = Color.white;
        outline.OutlineMode = Outline.Mode.OutlineAll;
        outline.OutlineWidth = 6;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
