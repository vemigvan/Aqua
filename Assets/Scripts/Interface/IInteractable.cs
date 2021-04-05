using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public interface IInteractable
{
    InteractionController InteractionController { get; }
    float InteractionDistance { get; }
    float StoppingDistance { get; }
    Transform Body { get; }
}

public abstract class InteractionController
{
    private IInteractable _thisInteractacble;
    private bool _isFocused;
    private Player _player;
    public bool HasInteracted { get; protected set; }

    public InteractionController(IInteractable _interactable)
    {
        _thisInteractacble = _interactable;
        ServiceManager.Instance.UpdateHandler += OnUpdate;
        ServiceManager.Instance.DestroyHandler += OnDestroy;
    }

    public void OnFocus(Player player)
    {
        _isFocused = true;
        _player = player;
    }

    public void OnUnfocus()
    {
        HasInteracted = false;
        Debug.Log("Unfocus");
    }
    private void OnUpdate()
    {
        if (_player != null && _isFocused)
        {
            if (Vector3.Distance(_thisInteractacble.Body.position, _player.transform.position) <= _thisInteractacble.InteractionDistance && !HasInteracted)
            {
                Interact();
            }
        }
    }
    public virtual void Interact()
    {
        HasInteracted = true;
    }

    public void OnDestroy()
    {
        ServiceManager.Instance.UpdateHandler -= OnUpdate;
        ServiceManager.Instance.DestroyHandler -= OnDestroy;
    }
}

public class NPCInteractionController : InteractionController
{
    public NPCInteractionController(IInteractable interactable) : base(interactable)
    {

    }

    public override void Interact()
    {
        base.Interact();
        Debug.Log("NPC - trade");
    }

}

public class EnemyInteractionController : InteractionController
{
    public EnemyInteractionController(IInteractable interactable) : base(interactable)
    {

    }

    public override void Interact()
    {
        base.Interact();
        Debug.Log("Enemy - fight");
    }

}

public class ItemInteractionController : InteractionController
{
    public ItemInteractionController(IInteractable interactable) : base(interactable)
    {

    }

    public override void Interact()
    {
        base.Interact();
        Debug.Log("Item - pickup");
    }

}