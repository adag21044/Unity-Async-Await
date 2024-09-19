using System.Threading.Tasks;
using UnityEngine;

public class MoveRightCommand : ICommand
{
    public async Task Execute()
    {
        await PlayerMovementManager.Instance.MoveAsync(Vector3.right);
    }
}