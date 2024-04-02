using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace OrganizareConcursInot.repository
{
    public interface ParticipantRepository<T,Id>
    {
        void addParticipant(T elem);
        void deleteParticipant(T elem);
        void updateParticipant(T elem, Id id);
        T findByIdParticipant(Id id);
        List<T> findAllParticipant();
    }
}