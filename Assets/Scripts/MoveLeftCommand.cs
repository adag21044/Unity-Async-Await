using System.Threading.Tasks;
using UnityEngine;

public class MoveLeftCommand : ICommand
{
    public async Task Execute()
    {
        await PlayerMovementManager.Instance.MoveAsync(Vector3.left);
    }
}