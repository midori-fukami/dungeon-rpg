using Godot;
using System;

public partial class PlayerMoveState : PlayerState
{
    public override void _PhysicsProcess(double delta)
    {
        if (characterNode.direction == Vector2.Zero)
        {
            characterNode.stateMachineNode.SwitchState<PlayerIdleState>();
            return;
        }

        characterNode.Velocity = new(characterNode.direction.X, 0, characterNode.direction.Y);
        characterNode.Velocity *= 5;

        characterNode.MoveAndSlide();
        characterNode.Flip();
    }

    protected override void EnterState()
    {
        base.EnterState();

        characterNode.animationPlayerNode.Play(GameConstants.ANIM_MOVE);
    }


    public override void _Input(InputEvent @event)
    {
        base._Input(@event);

        if (Input.IsActionJustPressed(GameConstants.INPUT_DASH)) {
            characterNode.stateMachineNode.SwitchState<PlayerDashState>();
        }
    }
}