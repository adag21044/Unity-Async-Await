using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private ICommand _moveForwardCommand;
    private ICommand _moveBackwardCommand;
    private ICommand _moveLeftCommand;
    private ICommand _moveRightCommand;

    private void Start()
    {
        _moveForwardCommand = new MoveForwardCommand();
        _moveBackwardCommand = new MoveBackwardCommand();
        _moveLeftCommand = new MoveLeftCommand();
        _moveRightCommand = new MoveRightCommand();
    }

    private async void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            await _moveForwardCommand.Execute();
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            await _moveBackwardCommand.Execute();
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            await _moveLeftCommand.Execute();
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            await _moveRightCommand.Execute();
        }
    }
}
