using System.Threading.Tasks;
using UnityEngine;

public class MoveBackwardCommand : ICommand
{
    public async Task Execute()
    {
        await PlayerMovementManager.Instance.MoveAsync(Vector3.back);
    }
}