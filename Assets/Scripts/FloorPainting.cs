using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorPainting : MonoBehaviour
{
    [SerializeField] private Color _activeColor;
    [SerializeField] private Color _defaltColor;
    [SerializeField] private LayerMask _groundLayerMask;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((_groundLayerMask.value & (1 << collision.gameObject.layer)) > 0)
        {
            SpriteRenderer other = collision.gameObject.GetComponent<SpriteRenderer>();
            if (other.color == _activeColor)
                other.color = _defaltColor;
            else other.color = _activeColor; 
        }
    }

    
}
