using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActionController : EntityActionController
{
    private Player _player;
    private Interactable _lastTarget;
    public PlayerActionController(Player player) : base(player)
    {
        _player = player;
        player.ServiceManager.PCInputController.LeftPointerClickHandler += OnLeftPointerClicked;   
    }

    private void OnLeftPointerClicked(Vector3 destination, Collider collider)
    {
        if (_lastTarget != null)
        {
            _lastTarget.OnUnfocus();
            _lastTarget = null;
        }

        if (collider != null)
        {
            _lastTarget = collider.GetComponent<Interactable>();
            if (_lastTarget != null)
            {
                _lastTarget.OnFocus(_player);
                Move(_lastTarget.transform.position, _lastTarget.StoppingDistance);
                return;
            }
        }
        Move(destination);
    }

    protected override void OnDestroy()
    {
        _player.ServiceManager.PCInputController.LeftPointerClickHandler -= OnLeftPointerClicked;
        base.OnDestroy();
    }
}
