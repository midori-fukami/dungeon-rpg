using Godot;
using System;

public partial class UIContainer : Container
{
    [Export] public ContainerType container { get; private set; }
    [Export] public Button ButtonNode { get; private set; }
    [Export] public TextureRect TextureRect { get; private set; }
    [Export] public Label Labelnode { get; private set; }
}