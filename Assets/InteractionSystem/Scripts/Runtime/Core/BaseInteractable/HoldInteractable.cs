public class HoldInteractable : BaseInteractable
{
    protected override void Awake()
    {
        base.Awake();
        InteractionType = InteractionTypeEnum.Hold;
    }
}