
using UnityEngine;

public class BotonPlay : Interactable
{
    [SerializeField] VideoManager _manager;

    public override void OnPointerClick()
    {
        base.OnPointerClick();
        _manager.PlayVideo();
    }
}
