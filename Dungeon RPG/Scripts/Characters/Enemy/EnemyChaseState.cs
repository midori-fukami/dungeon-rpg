using Godot;
using System;

public partial class EnemyChaseState : EnemyState
{
    protected override void EnterState()
    {
        characterNode.AnimationPlayerNode.Play(GameConstants.ANIM_MOVE);
        GD.Print("chase state");
    }
}