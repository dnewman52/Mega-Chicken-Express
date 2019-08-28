using UnityEngine;
using UnityEngine.InputNew;

// GENERATED FILE - DO NOT EDIT MANUALLY
public class ChickenInput_Xbox : ActionMapInput {
	public ChickenInput_Xbox (ActionMap actionMap) : base (actionMap) { }
	
	public AxisInputControl @moveX { get { return (AxisInputControl)this[0]; } }
	public AxisInputControl @moveY { get { return (AxisInputControl)this[1]; } }
	public Vector2InputControl @movement { get { return (Vector2InputControl)this[2]; } }
}
