namespace PACM.BL
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }

    public abstract class EntityBase
    {
        public EntityStateOption EntityeState { get; set; }
        public bool HasChanges { get; set; }
        public bool IsNew { get; set; }
        public bool IsValid => Validate();

        public abstract bool Validate();
    }
}
