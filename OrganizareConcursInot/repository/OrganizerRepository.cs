using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace OrganizareConcursInot.repository
{
    public interface OrganizerRepository<T,Id>
    {
        void addOrganizer(T elem);
        void deleteOrganizer(T elem);
        void updateOrganizer(T elem, Id id);
        T findByIdOrganizer(Id id);
        List<T> findAllOrganizer();
    }
}