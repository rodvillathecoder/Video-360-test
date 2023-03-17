
using UnityEngine;

public class BotonPausa : Interactable
{
    [SerializeField] VideoManager _manager;

    public override void OnPointerClick()
    {
        base.OnPointerClick();
        _manager.PauseVideo();
    }
}
