namespace OrganizareConcursInot.domain
{
    public interface Entity<Id>
    {
        Id getId();
        void setId(Id id);
    }
}