public class InstantInteractable : BaseInteractable
{
    protected override void Awake()
    {
        base.Awake();
        InteractionType = InteractionTypeEnum.Instant;
    }
}